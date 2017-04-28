using System.Collections.Generic;
using System.Web;

namespace Realtair.Framework.Core.Web.Utilities
{
    using Core.Entities;
    using System.Web.Security;
    using System;
    using Framework.Core.Interfaces;

    public class Authentication : IAuthentication
    {
        readonly HttpResponseBase Response;
        readonly HttpRequestBase Request;

        public Authentication(HttpResponseBase response, HttpRequestBase request)
        {
            Response = response;
            Request = request;
        }

        private static string CookieName => "REALTAIR_SESSION";

        public bool IsLoggedIn => GetUserID() != -1;
        public int LoggedInUserId => GetUserID();

        public void LogOut() => Response.Cookies.Set(new HttpCookie(CookieName, ""));
        public void LogIn(Framework.Core.Entities.User user)
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

        protected int GetUserID()
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