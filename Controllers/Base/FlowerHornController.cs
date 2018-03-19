using Realtair.Assist.Web.Attributes;
using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Web.Controllers;
using Realtair.Framework.Core.Web.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using DateTime = System.DateTime;
using Math = System.Math;

namespace Realtair.Framework.Web.Controllers
{
#if SSO_DISABLED
    // Authorize attribute excluded...
#else
    [Authorize]
#endif
    public abstract class FlowerHornController : BaseController
    {
        // Fields
        private Dictionary<string, int> colorCodes = new Dictionary<string, int>()
        {
            { "green", 0 },
            { "yellow", 1 },
            { "red", 2 },
            { "blue", 3 }
        };

        // Properties
        protected Dictionary<string, int> ColorCodes => colorCodes;
        public string Title { get; set; }

        // Constructors
        public FlowerHornController(IAuthenticationFactory authenticationFactory) : base(authenticationFactory)
        {
        }

        // Base Methods
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var attribute = filterContext.ActionDescriptor
                .GetCustomAttributes(typeof(AuthorizedUserRolesAttribute), false)
                .FirstOrDefault() as AuthorizedUserRolesAttribute;

            if (attribute != null && !attribute.UserRoles.Contains(User.RoleType))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "dashboard",
                    action = "dashboard"
                }));
            }
        }

        // Methods
        protected string GetTaskColorCode(bool isVip, DateTime created)
        {
            var dateDiff = (int)Math.Floor((DateTime.Now - created).TotalHours);
            return ColorCodes.FirstOrDefault(c => c.Value == (isVip ? 3 : (dateDiff <= 2 ? dateDiff : 2))).Key;
        }
    }
}