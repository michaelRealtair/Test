using System.Collections.Generic;
using System.Web;

namespace Realtair.Framework.Core.Web.Utilities
{
    using Core.Entities;
    using System.Web.Security;
    using System;
    using Framework.Core.Interfaces;
    using System.Security.Principal;
    using System.Security.Claims;

    public class Authentication : IAuthentication
    {
        readonly ClaimsPrincipal claimsPrincipal;
        readonly HttpResponseBase response;
        readonly HttpRequestBase request;

        public Authentication(HttpResponseBase response, HttpRequestBase request)
        {
            this.response = response;
            this.request = request;
        }
        public Authentication(HttpResponseBase response, HttpRequestBase request, IPrincipal user) : this(response, request)
        {
            claimsPrincipal = user as ClaimsPrincipal;
        }

        private static string CookieName => "REALTAIR_SESSION";

        public bool IsLoggedIn => GetUserID() != -1;
        public int LoggedInUserId => GetUserID();

        public void LogOut() => response.Cookies.Set(new HttpCookie(CookieName, ""));
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

            response.Cookies.Set(new HttpCookie(CookieName, encryptedTicket));
        }

        protected int GetUserID()
        {
            int userId;

            try
            {
                // If claims principal is not null, use identity server cookies...
                if (claimsPrincipal != null)
                {
                    String sub = null;
                    String email = null;
                    Boolean hasExpired = false;

                    // Check if user id is included
                    if (claimsPrincipal != null && claimsPrincipal.HasClaim(c => c.Type == "sub"))
                    {
                        sub = claimsPrincipal.FindFirst(c => c.Type == "sub")?.Value;
                    }

                    // Check if email is included
                    if (claimsPrincipal != null && claimsPrincipal.HasClaim(c => c.Type == "email"))
                    {
                        email = claimsPrincipal.FindFirst(c => c.Type == "email")?.Value;
                    }

                    // Check if expiry date is included and if it has expired or not...
                    DateTime expires_at;
                    hasExpired = claimsPrincipal != null &&
                        DateTime.TryParse(claimsPrincipal.FindFirst(c => c.Type == "expires_at")?.Value, out expires_at) &&
                        expires_at <= DateTime.UtcNow;

                    if (string.IsNullOrEmpty(sub) || string.IsNullOrEmpty(email) || hasExpired || !int.TryParse(sub, out userId))
                    {
                        userId = -1;
                    }
                }
                // Else, use forms authentication cookie
                else
                { 
                    var cookie = request.Cookies.Get(CookieName);
                    var cookieValue = cookie != null ? request.Cookies.Get(CookieName).Value : "";
                    var ticket = FormsAuthentication.Decrypt(cookieValue);

                    if (string.IsNullOrEmpty(cookieValue) || ticket.Expired || !int.TryParse(ticket.Name, out userId))
                    {
                        userId = -1;
                    } 
                }
            }

            catch (ArgumentException)
            {
                userId = -1;
            }

            return userId;

        }
    }
}