using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.IdentityServer.Utilities;
using Realtair.Framework.Core.Interfaces;
using System;
using System.Security.Principal;
using System.Web;

namespace Realtair.Framework.Core.Web.Utilities
{
    public class SingleSignOnAuthentication : AuthenticationBase, IAuthentication
    {
        // Constructors
        public SingleSignOnAuthentication(HttpResponseBase response, HttpRequestBase request)
            : base(response, request)
        {
        }
        public SingleSignOnAuthentication(HttpResponseBase response, HttpRequestBase request, IPrincipal user)
            : base(response, request, user)
        {
        }

        // Methods
        public override void LogIn(User user)
        {
            // Not required when using single sign on...
        }
        public override void LogOut()
        {
            this.ClearCookies();
            Request.GetOwinContext().Authentication.SignOut();
        }
        protected override int GetUserID()
        {
            var sub = ClaimsPrincipal?.Get("sub")?.Value;
            var email = ClaimsPrincipal?.Get("email")?.Value;
            var expiry = ClaimsPrincipal?.Get("expires_at")?.Value;

            // Check if expiry date is included, if it has expired or not, and that id is a number...
            int userId;
            DateTime expiryDate;
            if (string.IsNullOrEmpty(sub) ||
                string.IsNullOrEmpty(email) ||
                (DateTime.TryParse(expiry, out expiryDate) && expiryDate <= DateTime.UtcNow) ||
                !int.TryParse(sub, out userId))
            {
                userId = -1;
            }

            return userId;
        }
    }
}
