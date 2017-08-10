using System.Web.Mvc;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class ErrorController : Controller
    {
        [Route("error")]
        [AllowAnonymous]
        public ActionResult Index(string errorType)
        {
            return View();
        }

        [Route("error/{errorType}")]
        [AllowAnonymous]
        public ActionResult HandleError(string errorType)
        {
            return View(errorType);
        }
    }
}
