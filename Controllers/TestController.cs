using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class TestController : Controller
    {
        public ActionResult Test()
        {
            return Content("aaaaay");
        }
    }
}
