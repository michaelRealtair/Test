using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Data;
using System.Security.Principal;
using Realtair.Framework.Core.Interfaces;
using System;
using Realtair.Framework.Core.Web.Utilities;

namespace Realtair.Framework.Core.Web.Controllers
{
    public abstract class BaseController : System.Web.Mvc.Controller
    {
        // Fields
        private User user;
        private IAuthenticationFactory authenticationFactory;

        // Properties
        public IPrincipal Principal => base.User;
        public DbContext DbContext
        {
            get
            {
                return SingletonDbContext.Instance.DbContext;
            }
        }
        protected virtual IAuthentication Auth => authenticationFactory.CreateInstance(Response, Request, Principal);
        protected new User User
        {
            get
            {
                if (Auth.IsLoggedIn && (user == null || user.RoleType == BaseRoleType.LoggedOut))
                    user = DbContext.Set<User>().Include(u => u.Person).FirstOrDefault(u => u.Id == Auth.LoggedInUserId);
                else if (user == null)
                    user = DbContext.Set<User>().First(u => u.RoleType == BaseRoleType.LoggedOut);

                return user;
            }
        }
        
        // Constructors
        public BaseController(IAuthenticationFactory authenticationFactory)
        {
            this.authenticationFactory = authenticationFactory;
        }

        // Methods
        protected override void Dispose(bool disposing)
        {
            if (disposing && DbContext != null)
            {
                if (DbContext.ChangeTracker.Entries().Any())
                    DbContext.SaveChanges();
                DbContext.Dispose();
                user = null;
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