using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using Hangfire;
using System.Web.Mvc;
using System.Data.Entity;
using Realtair.Framework.Enquiries.Entities;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Web.Utilities;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class EnquiryController : BaseController
    {
        public class EnquiryViewModel
        {
            public BaseEnquiry Workflow { get; set; }
            public Conversation Conversation { get; set; }
            public List<IBaseUser> Participants { get; set; }
            public List<Conversation> Conversations { get; set; }
            public List<Conversation> ExternalConversations { get; set; }
            public List<Attachment> Attachments { get; set; } = new List<Attachment>();
            public List<BaseEnquiry> RelatedEnquiries { get; set; } = new List<BaseEnquiry>();
            public List<Task> RelatedTasks { get; set; } = new List<Task>();
            public IEnumerable<ITimelineItem> Timeline { get; set; }
        }

        //[Route("{enquiryTypeName}/{id:int}/chat")]
        public ActionResult Enquiry(string enquiryTypeName, int id, int? conversationId)
        {
            if (User.RoleType == UserRoleType.LoggedOut)
                return Redirect("/");

            var model = new EnquiryViewModel();

            model.Workflow = CoreExtensions.GetEnquiry(DbContext, id);

            var conversationEnquiry = model.Workflow.ParentEnquiry != null ? model.Workflow.ParentEnquiry : model.Workflow;

            model.Conversations = conversationEnquiry.Conversations.Where(c => c.Users.Contains(User)).ToList();

            model.ExternalConversations = model.Workflow.Conversations.Where(c => !c.Users.Contains(User) && c.AccessibleTo(User, DbContext)).ToList();
            conversationId = conversationId.HasValue ? conversationId : model.Conversations?.OrderByDescending(c => c.ActiveNotifications(User, model.Workflow).Count())?.FirstOrDefault()?.Id ?? (model.ExternalConversations.Count() > 0 ? model.ExternalConversations?.First().Id : null);

            if(conversationId == null) return Redirect("/");

            model.Conversation = conversationEnquiry.Conversations.Single(c => c.Id == conversationId);
            model.Participants = conversationEnquiry.Conversations.Single(c => c.Id == conversationId).Users.ToList();

            model.Timeline = model.Conversation.Timeline(User, DbContext, model.Workflow);
            model.RelatedEnquiries = model.Workflow.ParentEnquiry == null ? model.Workflow.RelatedEnquiries.ToList() : model.Workflow.ParentEnquiry.RelatedEnquiries.Where(e => e != model.Workflow).Concat(new[] { model.Workflow.ParentEnquiry }).ToList();

            var _relatedIds = model.Workflow.RelatedEnquiries.Select(e => e.Id).Concat(new[] { model.Workflow.Id });
            model.RelatedTasks = DbContext.Set<TaskRecord>().Where(t => !t.Dismissed && _relatedIds.Contains(t.Enquiry.Id)).ToList().Select(t => t.Task(DbContext)).ToList();

            foreach (var conversation in model.Workflow.Conversations)
            {
                foreach (var timelineItem in conversation.Timeline(User, DbContext, model.Workflow))
                {
                    if (timelineItem is TimelineEvent)
                    {
                        var thisState = timelineItem as TimelineEvent;
                        if (thisState is IShowAttachments && (thisState as IShowAttachments).Attachments.Count() > 0)
                        {
                            foreach (var attachment in (thisState as IShowAttachments).Attachments)
                            {
                                if (!model.Attachments.Contains(attachment))
                                    model.Attachments.Add(attachment);
                            }
                        }
                    }

                    if (timelineItem is Message)
                    {
                        var thisMessage = timelineItem as Message;
                        if (thisMessage.Attachments.Count > 0)
                        {
                            foreach (var attachment in thisMessage.Attachments)
                            {
                                if (!model.Attachments.Contains(attachment))
                                    model.Attachments.Add(attachment);
                            }
                        }
                    }
                }
            }

            if (!model.Conversation.AccessibleTo(User, DbContext)) return Redirect("/");

            var notificationIds = model.Conversation.ActiveNotifications(User, model.Workflow).Select(n => n.Id);
            // not 100% sure if ommitting this'll cause optimistic concurrency exceptions, but i'm going to be paranoid and add it to our serial queue
            //BackgroundJob.Enqueue(() => DismissAllNotifications(notificationIds));

            Response.AddHeader("Cache-Control", "no-cache, max-age=0, must-revalidate, no-store");

            //ConversationHub.AddOnlineUsers(id.ToString(), User.Id.ToString());

            return View("Enquiry", model);
        }

        public void DismissAllNotifications(IEnumerable<int> notificationIds)
        {
            var notifications = DbContext.Set<Notification>().Where(n => notificationIds.Contains(n.Id));
            foreach (var n in notifications)
                n.Dismissed = true;
            DbContext.SaveChanges();
        }

        //[Route("{enquiryTypeName}/{id:int}/chat/{conversationId:int}")]
        public ActionResult Conversation(string enquiryTypeName, int id, int conversationId)
        {
            return Enquiry(enquiryTypeName, id, conversationId);
        }

        //[Route("{enquiryTypeName}/{id:int}/chat/{conversationId:int}/send-message"), HttpPost, ValidateInput(false)]
        public ActionResult SendMessage(string enquiryTypeName, int id, int conversationId, string messageText, string[] attachments, string[] existingAttachments)
        {
            var conversation = DbContext.Set<Conversation>().First(c => c.Id == conversationId);

            if (!conversation.AccessibleTo(User, DbContext)) return new HttpStatusCodeResult(403);

            var attachmentsForMessage = attachments == null ? new List<Attachment>() :
                attachments.Select(f => new ActionMapper(DbContext).MapFileAsset(f)).ToList();

            if (existingAttachments != null)
            {
                foreach (string existingAttachment in existingAttachments)
                {
                    var storageGuid = new Guid(existingAttachment);
                    var originalAttachment = DbContext.Set<Attachment>().Where(a => a.StorageGuid == storageGuid).FirstOrDefault();
                    attachmentsForMessage.Add(new Attachment(originalAttachment));
                }
            }

            var enquiry = CoreExtensions.GetEnquiry(DbContext, id);
            var message = new Message(enquiry, conversation, User, messageText, attachmentsForMessage, DbContext);

            DbContext.SaveChanges();

            //ConversationHub.NewMessageSent(conversationId, message.GlobalId);

            return Content(message.GlobalId.ToString());
        }

        //[Route("{enquiryTypeName}/{id:int}/chat/{conversationId:int}/get-updated-timeline")]
        public ActionResult GetUpdatedTimeline(string enquiryTypeName, int id, int conversationId, bool isActive)
        {
            var enquiry = CoreExtensions.GetEnquiry(DbContext, id);
            var conversation = DbContext.Set<Conversation>().Find(conversationId);//DbContext.Set<Conversation>().First(c => c.Id == conversationId);

            IEnumerable<ITimelineItem> timeline = conversation.Timeline(User, DbContext, enquiry).OrderBy(o => o.TimelineDate);

            if (isActive)
            {
                var notificationIds = conversation.ActiveNotifications(User, enquiry).Select(n => n.Id);
                // not 100% sure if ommitting this'll cause optimistic concurrency exceptions, but i'm going to be paranoid and add it to our serial queue
                //BackgroundJob.Enqueue(() => DismissAllNotifications(notificationIds));
            }

            if (!conversation.Enquiry.AccessibleTo(User, DbContext)) return new HttpStatusCodeResult(403);

            return View("Timeline", timeline);
        }

        //[Route("{enquiryTypeName}/{id:int}/chat/{conversationId:int}/get-timeline-item/{timelineItem}/{isActive}")]
        public ActionResult GetTimelineItem(string enquiryTypeName, int id, int conversationId, string timelineItem, bool isActive)
        {
            IEnumerable<ITimelineItem> timeline = CoreExtensions.GetEnquiry(DbContext, id).Conversations.Single(c => c.Id == conversationId).
            Timeline(User, DbContext).Where(t => t.GlobalId == Guid.Parse(timelineItem));

            if (isActive)
                DbContext.Set<Notification>().Where(n => n.User.Id == User.Id).ToList().ForEach(f => { f.LastSeen = DateTime.Now; });

            return View("Timeline", timeline);
        }
    }

    /*public class ConversationHub : BaseHub
    {
        private static IHubContext hubContext = GlobalHost.ConnectionManager.GetHubContext<ConversationHub>();
        public static Dictionary<string, string> userHubs = new Dictionary<string, string>();

        public static void NewMessageSent(int conversationId, Guid messageId)
        {
            hubContext.Clients.Group(conversationId.ToString()).newMessageReceived(messageId.ToString());
        }

        public static void AddOnlineUsers(string conversationId, string userId)
        {
            if (!userHubs.ContainsKey(userId))
            {
                userHubs.Add(userId, conversationId);
            }
            else
            {
                userHubs[userId] = conversationId;
            }
        }

        public System.Threading.Tasks.Task LeaveRoom(string roomName)
        {
            return Groups.Remove(Context.ConnectionId, roomName);
        }

        public async System.Threading.Tasks.Task JoinRoom(string roomName)
        {
            await Groups.Add(Context.ConnectionId, roomName);
        }
    }*/
}