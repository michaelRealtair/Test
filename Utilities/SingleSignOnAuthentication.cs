using Realtair.Framework.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realtair.Framework.Core.Entities;
using System.Security.Principal;
using System.Security.Claims;

namespace Realtair.Framework.Core.Web.Utilities
{
    public class SingleSignOnAuthentication : IAuthentication
    {
        // Fields
        private IPrincipal user;

        // Properties
        public bool IsLoggedIn => GetUserID() != -1;
        public int LoggedInUserId => GetUserID();

        // Constructors
        public SingleSignOnAuthentication(IPrincipal user)
        {
            this.user = user;
        }

        // Methods
        public void LogIn(User user)
        {
            throw new NotImplementedException();
        }
        public void LogOut()
        {
            throw new NotImplementedException();
        }
        protected int GetUserID()
        {
            int userId;

            try
            {
                String sub = null;
                String email = null;
                Boolean hasExpired = false;
                ClaimsPrincipal claimsPrincipal = this.user as ClaimsPrincipal;

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
            catch
            {
                userId = -1;
            }

            return userId;
        }
    }
}
