using Realtair.Framework.Core.Actions.FieldAttributes;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Action = Realtair.Framework.Core.Actions.Action;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class SettingsController : BaseController
    {
        public SettingsController(IAuthenticationFactory authenticationFactory)
            : base(authenticationFactory)
        {
        }

        public class ViewModel
        {
            public IHasSettings Entity { get; set; }
            public string Description { get; set; }
            public IEnumerable<Action> Actions { get; set; }
            public Action SelectedAction { get; set; }
            public bool Submitted { get; set; }
        }

        //[Route("{entityTypeName}/{id:int}/settings")]
        public ActionResult Settings(string entityTypeName, int id)
        {
            var s = CoreExtensions.GetEntity(DbContext, entityTypeName, id) as IHasSettings;

            if (s is IProtectedAccess)
                if (!(s as IProtectedAccess).AccessibleTo(User, DbContext)) return View("Unauthorize");

            var actions = s.Settings().WithAccess(User, DbContext).ToList();
            foreach (var a in actions) a.Setup(DbContext, User, Auth);
            var vm = new ViewModel { Entity = s, Description = s.Description(User), Actions = actions, SelectedAction = actions?.FirstOrDefault() };

            return View(vm);
        }

        //[Route("{entityTypeName}/{id:int}/settings/{actionName}"), HttpPost, ValidateInput(false)]
        public ActionResult UpdateSetting(string entityTypeName, int id, string actionName)
        {
            var s = CoreExtensions.GetEntity(DbContext, entityTypeName, id) as IHasSettings;
            var a = s?.Settings().WithAccess(User, DbContext).FirstOrDefault(sa => sa.ActualType().Name == CoreExtensions.DashesToCamelcase(actionName));
            a.Setup(DbContext, User, Auth);

            foreach (var field in a.Fields)
            {
                object value;
                if (Request.Files.AllKeys.Contains(field.UniqueName))
                    value = (object)Request.Files.Get(field.UniqueName);
                else if(field.FieldAttribute is RecurringFieldAttribute)
                    value = HttpUtility.HtmlDecode(Request.Form.GetValues(field.UniqueName)[0]);
                else if (typeof(IEnumerable<object>).IsAssignableFrom(field.PropertyType))
                    value = Request.Form.GetValues(field.UniqueName);
                else
                    value = (object)Request.Form.Get(field.UniqueName);

                field.PropertyInfo.SetValue(a, new ActionMapper(DbContext).Map(a, field, field.PropertyInfo.PropertyType, value));
            }

            a.Validate();

            if (a.IsValid)
            {
                a.Run(User);
                DbContext.SaveChanges();
            }

            var actions = s.Settings().WithAccess(User, DbContext).ToList();
            foreach (var sa in actions) sa.Setup(DbContext, User, Auth);
            actions[actions.FindIndex(sa => sa.ActualType().IsAssignableFrom(a.ActualType()))] = a;

            var vm = new ViewModel { Entity = s, Description = s.Description(User), Actions = actions, SelectedAction = a, Submitted = true };

            if (a.IsValid)
                return RedirectToAction("SettingSuccess", new { entityTypeName = entityTypeName, id = id, actionName = actionName });

            return View("Settings", vm);
        }
        
        //[Route("{entityTypeName}/{id:int}/settings/{actionName}/success")]
        public ActionResult SettingSuccess(string entityTypeName, int id, string actionName)
        {
            var s = CoreExtensions.GetEntity(DbContext, entityTypeName, id) as IHasSettings;
            var a = s?.Settings().WithAccess(User, DbContext).FirstOrDefault(sa => sa.ActualType().Name == CoreExtensions.DashesToCamelcase(actionName));
            a.Setup(DbContext, User, Auth);

            if (s is IProtectedAccess)
                if (!(s as IProtectedAccess).AccessibleTo(User, DbContext)) return View("Unauthorize");

            var actions = s.Settings().WithAccess(User, DbContext).ToList();
            foreach (var sa in actions) sa.Setup(DbContext, User, Auth);
            actions[actions.FindIndex(sa => sa.ActualType().IsAssignableFrom(a.ActualType()))] = a;
            var vm = new ViewModel { Entity = s, Description = s.Description(User), Actions = actions, SelectedAction = a, Submitted = true };

            return View("Settings", vm);
        }
    }
}