using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

namespace Realtair.Framework.Core.Web.Utilities
{
    public static class ConfigureRoutes
    {
        public static void ConfigureBase(this RouteCollection routes)
        {
            ControllerBuilder.Current.DefaultNamespaces.Add("Realtair.Framework.Core.Web.Controllers");

            var db = Activator.CreateInstance("Realtair.LeadManagement.Core", "Realtair.LeadManagement.Core.Data.DbContext").Unwrap();
            routes.MapRoute("Test", "test", new { controller = "Test", action = "Test" });

            #region Action Routes
            routes.MapRoute("NewWorkflowAction", "{workflowName}/run/{actionName}",
                new { controller = "Actions", action = "NewWorkflowAction" });

            routes.MapRoute("LoadWorkflowAction", "{workflowName}/{id:int}/run/{actionName}",
                new { controller = "Actions", action = "LoadWorkflowAction" });

            routes.MapRoute("LoadWorkflowActionAsUser", "{workflowName}/{id:int}/{asUserId:int}/run/{actionName}",
                new { controller = "Actions", action = "LoadWorkflowActionAsUser" });

            routes.MapRoute("SecureAction", "secure-action/{hashedkey}",
                new { controller = "Actions", action = "SecureAction" });

            routes.MapRoute("UploadAttachment", "actions/functions/upload-attachment",
                new { controller = "Actions", action = "UploadAttachment" });

            routes.MapRoute("QueryProvider", "{workflowName}/{id:int}/run/{actionName}/query",
                new { controller = "Actions", action = "QueryProvider" });
            #endregion
        }
    }
}
