using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Action = Realtair.Framework.Core.Actions.Action;

namespace Realtair.Framework.Core.Web.Utilities
{
    using Core.Data;
    using Core.Entities;
    using Framework.Core.Interfaces;
    using Framework.Core.Reports;
    using Framework.Enquiries.Entities;
    using Framework.Enquiries.Interfaces;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Reflection;
    public static class CoreExtensions
    {
        public static string GetUrl(this IHasEvents workflow, UrlHelper url)
        {
            return url.Action("Enquiry", "Enquiry", new
            {
                enquiryTypeName = workflow.UrlSafeName(),
                id = workflow.Id
            });
        }

        public static string GetUrl(this object Object, User user, UrlHelper url)
        {
            if (Object is MessageNotification)
                return GetUrl((Object as MessageNotification).Message.Conversation, user, url);
            if (Object is EventNotification)
                return GetUrl((Object as EventNotification).Enquiry, user, url);
            if (Object is Enquiry)
                return GetUrl(Object as Enquiry, url);
            if (Object is Conversation)
                return GetUrl(Object as Conversation, (Object as Conversation).Enquiry, url);
            if (Object is IExtendedEnquiry)
                return GetUrl((Object as IExtendedEnquiry).Enquiry, url);
            else if (Object is Report)
                return GetUrl(Object as Report, url);
            else if (Object is Action)
                return GetUrl(Object as Action, url);
            else if (Object is Message)
                return GetUrl((Object as Message).Conversation, url);
            else if (Object is Attachment)
                return GetUrl((Object as Attachment), 0);
            else if (Object is IHasDisplayable)
                return GetDetailsUrl((Object as IHasDisplayable).Displayable, user, url);
            else
                return GetDetailsUrl(Object, user, url);
        }

        public static string GetUrl(this Action action, UrlHelper url, string redirectUrl = null, User u = null)
        {
            if (action.CalledBy == null || action.CalledBy.Id == 0)
                return url.Action("NewWorkflowAction", "Actions", new
                {
                    workflowName = action.CalledBy.UrlSafeName(),
                    actionName = action.UrlSafeName(),
                    redirectUrl
                });
            else if (u != null)
                return url.Action("LoadWorkflowActionAsUser", "Actions", new
                {
                    workflowName = action.CalledBy.UrlSafeName(),
                    id = action.CalledBy.Id,
                    asUserId = u.Id,
                    actionName = action.UrlSafeName(),
                    redirectUrl
                });
            else
            {
                return url.Action("LoadWorkflowAction", "Actions", new
                {
                    workflowName = action.CalledBy.UrlSafeName(),
                    id = action.CalledBy.Id,
                    actionName = action.UrlSafeName(),
                    redirectUrl
                });
            }
        }

        public static string GetUrl(this TimelineEvent timelineEvent, User user, UrlHelper url)
        {
            var enquiry = timelineEvent.Workflow is Enquiry ?
                timelineEvent.Workflow as Enquiry : timelineEvent.Workflow.ParentEnquiry;

            var conversation = enquiry.Conversations.FirstOrDefault(
                c => c.Users.Contains(user) && c.Users.Contains(timelineEvent.UserResponsible));

            if (conversation != null)
                return conversation.GetUrl(url);
            else
                return enquiry.GetUrl(url);
        }

        public static string GetUrl(this Notification timelineEvent, Enquiry forEnquiry, User user, UrlHelper url)
        {
            if (timelineEvent is MessageNotification)
                return (timelineEvent as MessageNotification).Message.Conversation.GetUrl(forEnquiry, url);
            else
                return forEnquiry.GetUrl(url);
        }

        public static string GetUrl(this Conversation conversation, Enquiry forEnquiry, UrlHelper url)
        {
            return url.Action("Conversation", "Enquiry", new
            {
                enquiryTypeName = conversation.Enquiry.UrlSafeName(),
                id = forEnquiry.Id,
                conversationId = conversation.Id
            });
        }
                
        public static string GetUrl(this Report report, UrlHelper url)
        {
            return $"/report/generate/{report.UrlSafeName()}";
        }

        public static string GetDetailsUrl(this object entity, Framework.Core.Entities.User user, UrlHelper url)
        {
            if (entity is IProtectedAccess)
                if (!(entity as IProtectedAccess).AccessibleTo(user, null)) return null;

            if (entity is IDisplayable)
                return url.Action("Details", "Details", new { entityTypeName = entity.UrlSafeName(), id = (entity as IEntity).Id });

            return null;
        }

        public static string UrlSafeName(this object toGetName)
        {
            return CamelcaseToDashes(toGetName.ActualType().Name);
        }

        public static string DisplaySafeName(this string input)
        {
            return Regex.Replace(input, "(?<!^)_?([A-Z])", " $1");
        }

        public static Entity GetEntity(DbContext db, string entityTypeName, int id)
        {
            return (Entity)db.Set(GetEntityType(entityTypeName)).Find(id);
        }


        public static IDisplayable GetDisplayable(DbContext db, string entityTypeName, int id)
        {
            var t = GetEntityType(entityTypeName);
            return (IDisplayable)db.Set(t).Find(id);
        }

        public static Type GetEntityType(string entityTypeName)
        {
            return AllTypes().Single(t => t.Name == DashesToCamelcase(entityTypeName));
        }

        public static Type GetActionType(Type actionable, string actionTypeName)
        {
            var all = AllTypes();
            var matches = all.Where(t => t.Name == DashesToCamelcase(actionTypeName));
            if (matches.Count() > 1)
                return matches.Single(
                    t => (t.GetConstructors()?.FirstOrDefault()?.GetParameters()?.Count() > 0) &&
                          t.GetConstructors()[0].GetParameters()[0].ParameterType.IsAssignableFrom(actionable));
            else
                return matches.First();
        }

        public static Report GetReport(string reportName)
        {
            return (Report)Activator.CreateInstance(AllTypes().Single(
                t => t.Name == DashesToCamelcase(reportName)));
        }

        public static Type ActualType(this object entity)
        {
            return ObjectContext.GetObjectType(entity.GetType());
        }

        public static IEnumerable<Type> AllTypes()
        {            
            return typeof(Entity).Assembly.GetTypes().Concat(Assembly.Load(ConfigurationManager.AppSettings["CoreAssembly"]).GetTypes());
        }

        public static IActionable GetActionable(string actionableName)
        {
            return (IActionable)Activator.CreateInstance(GetEntityType(DashesToCamelcase(actionableName)), true);
        }

        public static Action GetAction(IActionable actionable, DbContext db, Utilities.Authentication auth, string actionName, Framework.Core.Entities.User user)
        {
            var actionType = GetActionType(actionable.ActualType(), actionName);
            var action = (Action)Activator.CreateInstance(actionType, actionable);
            action.Setup(db, user, auth);

            return action;
        }

        public static Action GetAction(DbContext db, Authentication auth, string workflowName, int workflowId, string actionName, Framework.Core.Entities.User user)
        {
            var actionable = GetEntity(db, workflowName, workflowId) as IActionable;
            return GetAction(actionable, db, auth, actionName, user);
        }

        public static Action GetAction(string workflowName, DbContext db, Authentication auth, string actionName, Framework.Core.Entities.User user)
        {
            var actionable = GetActionable(workflowName);
            return GetAction(actionable, db, auth, actionName, user);
        }

        public static string CamelcaseToDashes(string input)
        {
            return Regex.Replace(input, "(?<=.)([A-Z])", "-$0", RegexOptions.Compiled).ToLower();
        }

        public static string DashesToCamelcase(string input)
        {
            return Regex.Replace(input, @"^\w|-\w",
                (match) => match.Value.Replace("-", "").ToUpper());
        }
        
        public static Enquiry GetEnquiry(DbContext db, int id)
        {
            return db.Set<Enquiry>().First(w => w.Id == id);
        }

        //FILE ASSET EXTENSIONS
        public static string GetUrl(this Attachment fileAsset, int width = 300) => fileAsset?.Url(width);
    }
}