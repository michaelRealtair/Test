using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Realtair.Framework.Core.Web.Controllers
{
    using Core.Data;
    using Core.Entities;
    using System;
    using System.Configuration;
    using System.Data.Entity;

    public class BaseController : System.Web.Mvc.Controller
    {
        private Core.Data.DbContext _Database;
        private User _User;

        public Core.Data.DbContext DbContext
        {
            get
            {
                if (_Database == null)
                {
                    var a = ConfigurationManager.AppSettings["CoreAssembly"];
                    var c = ConfigurationManager.AppSettings["CoreContext"];

                    _Database = (Data.DbContext)Activator.CreateInstance(a, c).Unwrap();
                    _Database.Database.CommandTimeout = 180;
                }

                return _Database;
            }
        }

        protected Utilities.Authentication Auth => new Utilities.Authentication(Response, Request);

        protected new User User
        {
            get
            {
                if (Auth.IsLoggedIn && (_User == null || _User.RoleType == UserRoleType.LoggedOut))
                    _User = DbContext.Set<User>().Include(u => u.Person).SingleOrDefault(u => u.Id == Auth.LoggedInUserId);
                else if (_User == null)
                    _User = DbContext.LoggedOutUser as User;

                return _User;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && _Database != null)
            {
                if (_Database.ChangeTracker.Entries().Any())
                    _Database.SaveChanges();
                _Database.Dispose();
                _Database = null;
                _User = null;
            }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.LoginSession = new LoginSession() { User = User };
            base.OnActionExecuting(filterContext);
        }

        protected string RenderPartialViewToString(string viewName, object model)
        {
            if (string.IsNullOrEmpty(viewName))
                viewName = ControllerContext.RouteData.GetRequiredString("action");

            if (model != null)
                ViewData.Model = model;

            using (System.IO.StringWriter sw = new System.IO.StringWriter())
            {
                ViewEngineResult viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
                viewResult.View.Render(viewContext, sw);

                return sw.GetStringBuilder().ToString();
            }
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            if (!HttpContext.IsDebuggingEnabled)
            {
                filterContext.Result = Redirect("/");
                filterContext.ExceptionHandled = true;
            }
        }
    }
}