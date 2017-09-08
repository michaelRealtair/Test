using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Realtair.Framework.Core.Web.Utilities.ConfigureRoutes), "Start")]
namespace Realtair.Framework.Core.Web.Utilities
{
    public static class ConfigureRoutes
    {
        public static void Start()
        {
            var routes = RouteTable.Routes;
            ControllerBuilder.Current.DefaultNamespaces.Add("Realtair.Framework.Core.Web.Controllers");           

            #region Action Routes
            routes.MapRoute("NewWorkflowAction", "{workflowName}/run/{actionName}",
                new { controller = "Actions", action = "NewWorkflowAction" });

            routes.MapRoute("LoadWorkflowAction", "{workflowName}/{id}/run/{actionName}",
                new { controller = "Actions", action = "LoadWorkflowAction" });

            routes.MapRoute("LoadWorkflowActionAsUser", "{workflowName}/{id}/{asUserId}/run/{actionName}",
                new { controller = "Actions", action = "LoadWorkflowActionAsUser" });

            routes.MapRoute("SecureAction", "secure-action/{hashedkey}",
                new { controller = "Actions", action = "SecureAction" });

            routes.MapRoute("UploadAttachment", "actions/functions/upload-attachment",
                new { controller = "Actions", action = "UploadAttachment" });

            routes.MapRoute("QueryProvider", "{workflowName}/{id}/run/{actionName}/query",
                new { controller = "Actions", action = "QueryProvider" });
            #endregion

            #region Setting Routes
            routes.MapRoute("Settings", "{entityTypeName}/{id}/settings",
                new { controller = "Settings", action = "Settings" });
            routes.MapRoute("UpdateSetting", "{entityTypeName}/{id}/settings/{actionName}",
               new { controller = "Settings", action = "UpdateSetting" });
            routes.MapRoute("SettingSuccess", "{entityTypeName}/{id}/settings/{actionName}/success",
               new { controller = "Settings", action = "SettingSuccess" });
            #endregion

            #region Search Routes
            routes.MapRoute("Search", "{entityTypeName}/search",
               new { controller = "Search", action = "Search" });            
            #endregion

            #region Report Route
            routes.MapRoute("Report", "report/{reportName}",
               new { controller = "Report", action = "Report" });
            routes.MapRoute("GenerateReport", "report/generate/{reportName}",
               new { controller = "Report", action = "GenerateReport" });
            #endregion

            #region Enquiry Route
            routes.MapRoute("Enquiry", "{enquiryTypeName}/{id}/chat",
              new { controller = "Enquiry", action = "Enquiry" });
            routes.MapRoute("Conversation", "{enquiryTypeName}/{id}/chat/{conversationId}",
              new { controller = "Enquiry", action = "Conversation" });
            routes.MapRoute("SendMessage", "{enquiryTypeName}/{id}/chat/{conversationId}/send-message",
              new { controller = "Enquiry", action = "SendMessage" });
            routes.MapRoute("GetUpdatedTimeline", "{enquiryTypeName}/{id}/chat/{conversationId}/get-updated-timeline",
              new { controller = "Enquiry", action = "GetUpdatedTimeline" });
            routes.MapRoute("GetTimelineItem", "{enquiryTypeName}/{id}/chat/{conversationId}/get-timeline-item/{timelineItem}/{isActive}",
              new { controller = "Enquiry", action = "GetTimelineItem" });
            routes.MapRoute("QueryUsers", "rest/users",
              new { controller = "Enquiry", action = "QueryUsers" });
            #endregion

            #region Details Route
            routes.MapRoute("Details", "{entityTypeName}/{id}/details",
              new { controller = "Details", action = "Details" });
            #endregion
        }
    }
}
