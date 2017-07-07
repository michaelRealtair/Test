using Realtair.Framework.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realtair.Framework.Core.Entities;
using System.Web;
using System.Security.Claims;
using System.Security.Principal;

namespace Realtair.Framework.Core.Web.Utilities
{
    public abstract class AuthenticationBase : IAuthentication
    {
        // Fields
        private ClaimsPrincipal claimsPrincipal;
        private HttpResponseBase response;
        private HttpRequestBase request;

        // Properties
        protected ClaimsPrincipal ClaimsPrincipal => claimsPrincipal;
        protected HttpResponseBase Response => response;
        protected HttpRequestBase Request => request;
        public bool IsLoggedIn => GetUserID() != -1;
        public int LoggedInUserId => GetUserID();

        // Constructors
        public AuthenticationBase()
        {
        }
        public AuthenticationBase(HttpResponseBase response, HttpRequestBase request)
        {
            this.response = response;
            this.request = request;
        }
        public AuthenticationBase(HttpResponseBase response, HttpRequestBase request, IPrincipal user) 
            : this(response, request)
        {
            claimsPrincipal = user as ClaimsPrincipal;
        }

        // Method
        public abstract void LogIn(User user);
        public abstract void LogOut();
        protected abstract int GetUserID();
        protected virtual void ClearCookies()
        {
            // Clear all cookies...
            foreach (var key in request.Cookies.AllKeys)
            {
                var cookie = new HttpCookie(key);
                cookie.Expires = DateTime.Now.AddDays(-1d);
                response.Cookies.Add(cookie);
            }
        }
    }
}
