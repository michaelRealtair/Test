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
        public bool IsLoggedIn
        {
            get
            {
                return GetUserID() != -1;
            }
        }

        public int LoggedInUserId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void LogIn(User user)
        {
            throw new NotImplementedException();
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        // Constructors
        public SingleSignOnAuthentication(IPrincipal user)
        {
            this.user = user;
        }

        // Methods
        protected int GetUserID()
        {
            int userId;

            try
            {
                var claimsPrincipal = (this.user.Identity as ClaimsPrincipal);
                if (claimsPrincipal != null && claimsPrincipal.HasClaim(c => c.Type == "email"))
                {
                    claimsPrincipal.FindFirst(c => c.Type == "email").Value;
                }

                var cookie = Request.Cookies.Get(CookieName);
                var cookieValue = cookie != null ? Request.Cookies.Get(CookieName).Value : "";
                var ticket = FormsAuthentication.Decrypt(cookieValue);
                
                if (string.IsNullOrEmpty(cookieValue) || ticket.Expired || !int.TryParse(ticket.Name, out userId))
                    return -1;

                return userId;
            }

            catch (ArgumentException)
            {
                return -1;
            }
        }
    }
}
