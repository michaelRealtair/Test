using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Web.Utilities;
using System.Web.Mvc;
using System.Web.Routing;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class DetailsController : BaseController
    {
        public DetailsController(IAuthenticationFactory authenticationFactory)
            : base(authenticationFactory)
        {
        }

        //[Route("{entityTypeName}/{id:int}/details")]
        public ActionResult Details(string entityTypeName, int id)
        {
            var entity = CoreExtensions.GetDisplayable(DbContext, entityTypeName, id);

            if (entity is IProtectedAccess)
                if (!(entity as IProtectedAccess).AccessibleTo(User, DbContext)) return View("Unauthorize");

            return View(entity);
        }
    }
}