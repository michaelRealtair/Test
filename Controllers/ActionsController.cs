using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Realtair.Framework.Core.Web.Controllers
{
    using Framework.Core.Actions;
    using Framework.Core.Actions.FieldAttributes;
    using Framework.Core.Actions.RedirectLocations;
    using Framework.Core.Actions.Users;
    using Framework.Core.Entities;
    using System.Web;
    using Utilities;
    using Interfaces;
    using System.Net;
    using System.Configuration;

    public class ActionsController : BaseController
    {
        private string dashboardUrl = ConfigurationManager.AppSettings["DashboardUrl"];
        bool PostValuesSet;

        public ActionsController(IAuthenticationFactory authenticationFactory) 
            : base(authenticationFactory)
        {
            if (string.IsNullOrWhiteSpace(dashboardUrl))
            {
                dashboardUrl = "/dashboard";
            }
        }

        public class ActionViewModel
        {
            public Action Action;
            public MultiPageAction MultiPageAction;
            public bool IsMultiPage;
            public MultiPageAction.Page Page;

            public ActionViewModel AdvanceToPage(MultiPageAction.Page nextPage)
            {
                SubmittedPages.Add(Page);
                Page = nextPage;
                return this;
            }

            public List<MultiPageAction.Page> SubmittedPages { get; set; } = new List<MultiPageAction.Page>();
            public IEnumerable<Field> Fields => Action.Fields;
            public IEnumerable<Field> FieldsForPage => Page.Fields;
            public IEnumerable<Field> HiddenFieldsForPage => Fields.Where(f => !FieldsForPage.Contains(f));
        }

        public ActionResult NewWorkflowAction(string workflowName, string actionName, string page = null, string submittedpagenames = null, bool back = false, bool cancel = false)
        {
            var action = CoreExtensions.GetAction(workflowName, DbContext, Auth, actionName, (Framework.Core.Entities.User)User);

            // Redirect right away if cancelled
            if (cancel) return HandleRedirect(action);

            return RunAction(action, User, page, submittedpagenames, back);
        }

        public ActionResult LoadWorkflowAction(string workflowName, int id, string actionName, string page = null, string submittedpagenames = null, bool back = false, bool cancel = false)
        {
            var action = CoreExtensions.GetAction(DbContext, Auth, workflowName, id, actionName, (Framework.Core.Entities.User)User);
            
            // Redirect right away if cancelled
            if (cancel) return HandleRedirect(action);

            return RunAction(action, User, page, submittedpagenames, back);
        }

        public ActionResult LoadWorkflowActionAsUser(string workflowName, int id, string actionName, int asUserId, string page = null, string submittedpagenames = null, bool back = false, bool cancel = false)
        {
            if (!(User.MeetsAuthLevel(BaseRoleType.Admin))) throw new AccessViolationException("Only Property Managers can run actions as another user");
            var user = DbContext.Set<User>().Single(u => u.Id == asUserId);
            var action = CoreExtensions.GetAction(DbContext, Auth, workflowName, id, actionName, user);

            // Redirect right away if cancelled
            if (cancel) return HandleRedirect(action);

            return RunAction(action, user, page, submittedpagenames, back);
        }

        public ActionResult SecureAction(string hashedkey, string page = null, string submittedpagenames = null, bool back = false, bool cancel = false)
        {
            var auth = DbContext.Set<AuthorisedAction>().Where(k => k.UniqueIdentifier == hashedkey).FirstOrDefault();
            var action = auth.GetAction(DbContext);
            action.Setup(DbContext, auth.User, Auth);

            // Redirect right away if cancelled
            if (cancel) return HandleRedirect(action);

            if (auth.ExpirationDate > DateTime.Now && !auth.IsUsed)
                return RunAction(action, auth.User, page, submittedpagenames, back, auth);
            else
                return Redirect(action.GetUrl());
        }

        public ActionResult UploadAttachment()
        {
            if (Request.Files.Count == 1)
            {
                var f = Request.Files[0];
                var a = new Attachment(f.FileName, f.ContentType, f.InputStream);
                DbContext.Set<Attachment>().Add(a);
                DbContext.SaveChanges();
                return Content(a.Id.ToString());
            }

            return Content("");
        }

        ActionResult RunAction(Action action, Framework.Core.Entities.User userToRunAs, string currentPageName, string submittedPageNames, bool back, AuthorisedAction auth = null)
        {
            MultiPageAction.Page givenPage = null;

            var model = new ActionViewModel();
            model.Action = action;

            if (action is MultiPageAction)
                givenPage = PrepareMultipageAction(action, userToRunAs, currentPageName, submittedPageNames, back, model);
            else if (Request.HttpMethod == "POST")
                SetPostValues(action, action.Fields);

            if (Request.HttpMethod == "POST")
            {
                action.BeforeRun(true);
                if (!action.AccessibleTo(userToRunAs, DbContext) && !(action is Login))
                    Response.Redirect(Url.Action("MainPage", "LandingPage") + "?ReturnUrl=" + Request.Url);

                return HandlePostAction(action, userToRunAs, back, givenPage, model, auth);
            }
            else

            {
                SetGetParams(action);
                action.BeforeRun(false);
                if (!action.AccessibleTo(userToRunAs, DbContext) && !(action is Login))
                    Response.Redirect(Url.Action("MainPage", "LandingPage") + "?ReturnUrl=" + Request.Url);

                if (action.Fields.Count() == 0)
                    return View("EmptyAction", model);
                else
                    return View("Action", model); // method was not post
            }
        }

        private ActionResult HandlePostAction(Action action, Framework.Core.Entities.User userToRunAs, bool back, MultiPageAction.Page givenPage, ActionViewModel model, AuthorisedAction auth)
        {
            if (back)
            {
                model.SubmittedPages.Remove(model.SubmittedPages.FirstOrDefault(p => p.GetType() == model.Page.GetType()));
                return View("Action", model);
            }
            else
            {
                MultiPageAction.Page nextPage = null;

                if (model.IsMultiPage)
                    nextPage = model.MultiPageAction.Validate(givenPage);
                else
                    action.Validate();

                if (action.IsValid)
                    if (action is MultiPageAction)
                        if (nextPage == null)
                            return RunActionAndRedirect(action, auth);
                        else
                            return View("Action", model.AdvanceToPage(nextPage));
                    else
                        return RunActionAndRedirect(action, auth);
                else
                    return View("Action", model);
            }
        }

        private ActionResult HandleRedirect(Action action, AuthorisedAction auth = null, string returnUrl = null)
        {
            IRedirectLocation RedirectLocation = null;

            if (auth != null)
            {
                if (Auth.IsLoggedIn)
                {
                    return Redirect("/"); 
                }
                else
                {
                    return View("SecureActionSuccessful", action);
                }
            }

            if (action.RedirectLocation == null)
            {
                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectLocation = new RedirectToDashboard();
                }
            }
            else
            {
                RedirectLocation = action.RedirectLocation;
            }

            if (RedirectLocation is RedirectToDashboard)
            {
                return Redirect(dashboardUrl);
            }
            else if (RedirectLocation is RedirectToEntity && (RedirectLocation as RedirectToEntity).Entity.Id != 0)
            {
                //return base.Redirect((RedirectLocation as RedirectToEntity).Entity.GetUrl((Framework.Core.Entities.User)User, Url));

                var redirectLocation = (RedirectLocation as RedirectToEntity);
                var entity = redirectLocation.Entity;
                var url = entity.GetUrl((Framework.Core.Entities.User)User, Url);
                return base.Redirect(url);
            }
            else if (RedirectLocation is RedirectToAction)
            {
                var newAction = (RedirectLocation as RedirectToAction);
                var url = newAction.Action.GetUrl(Url);
                for (int i = 0; i < newAction.UrlParameters.Count(); i++)
                    url += (i == 0 ? "?" : "&") + newAction.UrlParameters[i].Key + "=" + newAction.UrlParameters[i].Value;

                return Redirect(url);
            }
            else if (RedirectLocation is RedirectToReport)
            {
                var newReport = (RedirectLocation as RedirectToReport).Report;
                var url = newReport.GetUrl(User, Url);
                for (int i = 0; i < newReport.Fields.Count(); i++)
                {
                    url += (i == 0 ? "?" : "&") + newReport.Fields.ElementAt(i).UniqueName + "=";
                    var v = newReport.Fields.ElementAt(i).Value;
                    if (v is Entity)
                        url += (v as Entity).Id;
                    else if (v is DateTime)
                        //url += ((DateTime)v).ToString("dd-MM-yyyy");
                        url += ((DateTime)v).ToString("yyyy-MM-dd");
                    else if (v == null)
                        url += "";
                    else
                        url += v.ToString();
                }

                // If the report includes a model, send it with the redirection 
                if (newReport.Model != null)
                {
                    // Sample: report-name
                    TempData[newReport.GetUrlSafeName()] = newReport.Model;
                }

                return Redirect(url);
            }
            else if (RedirectLocation is RedirectToURL)
            {
                return Redirect((RedirectLocation as RedirectToURL).Url);
            }
            else if (RedirectLocation is RedirectToActionAsUser)
            {
                var redirect = (RedirectToActionAsUser)RedirectLocation;
                return base.Redirect(redirect.Action.GetUrl(Url, null, (Framework.Core.Entities.User)redirect.User));
            }
            else if (RedirectLocation is RedirectToHomepage)
            {
                return Redirect("/");
            }
            else
            {
                throw new ArgumentOutOfRangeException("RedirectLocation", action.RedirectLocation, "Don't know how to handle this type of RedirectLocation");
            }
        }

        private MultiPageAction.Page PrepareMultipageAction(Action action, Framework.Core.Entities.User userToRunAs, string currentPageName, string submittedPageNames, bool back, ActionViewModel model)
        {
            var multipageAction = (MultiPageAction)action;

            model.Page = currentPageName == null ? multipageAction.GetFirstPage() : multipageAction.PageByName(currentPageName);

            var givenPage = model.Page;

            if (Request.HttpMethod == "POST")
                SetPostValues(multipageAction, action.Fields);

            if (submittedPageNames != null && submittedPageNames.Length >= 1)
                model.SubmittedPages = submittedPageNames.Split(',').ToList().Select(p => multipageAction.PageByName(p)).ToList();

            model.Page = back ? model.SubmittedPages.Last() : givenPage;
            model.IsMultiPage = true;
            model.MultiPageAction = multipageAction;
            return givenPage;
        }

        private ActionResult RunActionAndRedirect(Action action, AuthorisedAction auth = null)
        {
            // Log/save the action to the database before running...
            action.StoreRecord();
            DbContext.SaveChanges();

            // Run the action
            if (auth != null)
            {
                action.Run(auth.User);
                auth.IsUsed = true;
            }
            else
            {
                action.Run((Framework.Core.Entities.User)User);
            }

            // Redirect...
            return HandleRedirect(action, auth, GetReturnUrl());
        }

        private string GetReturnUrl()
        {
            var returnUrl = string.Empty;
            try
            {
                if (Request.Form["ReturnUrl"] != null)
                    returnUrl = Request.Form["ReturnUrl"].ToString();
                else
                {
                    var uri = new Uri(Request.UrlReferrer.ToString());
                    returnUrl = (uri.Query != "" && uri.Query != "?") ? HttpUtility.ParseQueryString(uri.Query).Get("ReturnUrl").ToString() : "";
                }                
            }
            catch (Exception)
            {
                // ignored
            }
            return returnUrl;
        }

        void SetGetParams(Action action)
        {
            foreach (var field in action.Fields)
                if (field.FieldAttribute.FromQueryParam != null)
                    if (Request.QueryString.AllKeys.Contains(field.FieldAttribute.FromQueryParam))
                        field.FormValue = new ActionMapper(DbContext).Map(action, field, field.PropertyType, Request.QueryString.Get(field.FieldAttribute.FromQueryParam));
        }

        void SetPostValues(Action action, IEnumerable<Field> fields)
        {
            if (PostValuesSet)
                return;
            else
                PostValuesSet = true;

            foreach (var field in fields)
            {
                // check if it's a list of things, i.e. List<FileAsset>
                if (field.PropertyInfo.PropertyType.IsGenericType && field.PropertyType.GetGenericTypeDefinition() == typeof(IList<>))
                {
                    if (Request.Form.GetValues(field.UniqueName) != null)
                    {
                        foreach (var value in Request.Form.GetValues(field.UniqueName))
                        {
                            var mapped = new ActionMapper(DbContext).Map(action, field, field.PropertyInfo.PropertyType.GetGenericArguments().First(), value);
                            if (mapped != null && field.FieldAttribute is FileUploadFieldAttribute)
                            {
                                // have to do this for file uploads (why?), see its mapper below
                                (field.PropertyInfo.GetValue(action) as dynamic).Add(mapped as dynamic);
                            }
                        }
                    }
                }
                else
                {
                    object value;

                    if (Request.Files.AllKeys.Contains(field.UniqueName))
                        value = (object)Request.Files.Get(field.UniqueName);
                    else
                    {
                        if (typeof(IEnumerable<object>).IsAssignableFrom(field.PropertyType))
                            value = Request.Form.GetValues(field.UniqueName);
                        else if (typeof(RichTextAreaFieldAttribute).IsAssignableFrom(field.FieldAttribute.GetType()))
                        {
                            // Wrap markup with outer div to fix alignment
                            value = (object)($"<div style=\"text-align: initial;\">{Request.Unvalidated.Form.Get(field.UniqueName)}</div>");
                        }
                        else
                            value = (object)Request.Unvalidated.Form.Get(field.UniqueName);
                    }

                    field.PropertyInfo.SetValue(action, new ActionMapper(DbContext).Map(action, field, field.PropertyInfo.PropertyType, value));
                }
            }
        }

        public ActionResult QueryProvider(string workflowName, int id, string actionName, string fieldName, string query)
        {
            var action = CoreExtensions.GetAction(DbContext, Auth, workflowName, id, actionName, (Framework.Core.Entities.User)User);

            SetGetParams(action);
            SetPostValues(action, action.Fields);

            var fieldProvider = action.Fields.First(f => f.PropertyInfo.Name == fieldName).FieldAttribute.GetProvider();

            return View("Fields/_ListFieldQueryResults", fieldProvider.Options(action, (Framework.Core.Entities.User)User, query));
        }
    }
}