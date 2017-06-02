using System.Collections.Generic;
using System.Web;
using Realtair.Framework.Core.IdentityServer.Utilities;

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

        public void LogOut()
        {
            // Clear all cookies...
            foreach (var key in request.Cookies.AllKeys)
            {
                var cookie = new HttpCookie(key);
                cookie.Expires = DateTime.Now.AddDays(-1d);
                response.Cookies.Add(cookie);
            }

            // Redirect to identity server sign out...
            if (claimsPrincipal != null)
            {
                UriBuilder ub = new UriBuilder();
                ub.Scheme = request.Url.Scheme;
                ub.Host = request.Url.Host;
                ub.Path = "signout";
                var query = HttpUtility.ParseQueryString(ub.Query);
                query["token"] = claimsPrincipal.GetValue("id_token");
                query["issuerUri"] = claimsPrincipal.GetValue("issuer_uri");
                ub.Query = query.ToString();
                response.Redirect(ub.ToString());
            }
        }
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
                    String sub = sub = claimsPrincipal.GetValue("sub");
                    String email = claimsPrincipal.GetValue("email"); ;
                    Boolean hasExpired = false;
                    
                    // Check if expiry date is included and if it has expired or not...
                    DateTime expires_at;
                    hasExpired = claimsPrincipal != null &&
                        DateTime.TryParse(claimsPrincipal.GetValue("expires_at"), out expires_at) &&
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