using System.Web;

namespace Realtair.Framework.Core.Web.Utilities
{
    using Framework.Core.Interfaces;
    using System;
    using System.Security.Principal;
    using System.Web.Security;

    public class Authentication : AuthenticationBase, IAuthentication
    {
        // Fields
        private static string CookieName => "REALTAIR_SESSION";

        // Constructors
        public Authentication(HttpResponseBase response, HttpRequestBase request) 
            : base(response, request)
        {
        }
        public Authentication(HttpResponseBase response, HttpRequestBase request, IPrincipal user) 
            : base(response, request, user)
        {
        }

        // Methods
        public override void LogOut()
        {
            this.ClearCookies();
        }
        public override void LogIn(Framework.Core.Entities.User user)
        {
            //create the authentication ticket
            var authTicket = new FormsAuthenticationTicket(
                1,
                user.Id.ToString(),  //user id
                DateTime.Now,
                DateTime.Now.AddHours(6),  // expiry
                true,  //persists
                ""
            );

            var encryptedTicket = FormsAuthentication.Encrypt(authTicket);

            Response.Cookies.Set(new HttpCookie(CookieName, encryptedTicket));
        }
        protected override int GetUserID()
        {
            try
            {
                var cookie = Request.Cookies.Get(CookieName);
                var cookieValue = cookie != null ? Request.Cookies.Get(CookieName).Value : "";
                var ticket = FormsAuthentication.Decrypt(cookieValue);

                var userId = -1;
                if (string.IsNullOrEmpty(cookieValue) || ticket.Expired || !int.TryParse(ticket.Name, out userId))
                    return -1;

                return userId;
            }

            catch (ArgumentException) { return -1; }
        }
    }
}