using Realtair.Framework.Core.Entities;
using Realtair.Framework.Core.Interfaces;
using Realtair.Framework.Core.Reports;
using Realtair.Framework.Core.Web.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Realtair.Framework.Core.Web.Controllers
{
    public class ReportController : BaseController
    {
        public class ReportViewModel
        {
            public string Name { get; set; }
            public IEnumerable<IWidget> Widgets { get; set; }
        }

        //[Route("report/{reportName}")]
        public FileContentResult Report(string reportName)
        {
            var r = GetReport(reportName);
            return new FileContentResult(r.Render(User, DbContext), "application/pdf");            
        }

        //[Route("report/generate/{reportName}")]
        public ActionResult GenerateReport(string reportName)
        {
            var r = GetReport(reportName);
            var vm = new ReportViewModel { Name = r.Description(User), Widgets = r.RenderWidgets(User, DbContext) };
            return View("Report", vm);
        }

        protected Report GetReport(string report)
        {
            var r = CoreExtensions.GetReport(report);
            r.Setup(DbContext, User, Auth);

            foreach (var field in r.Fields)
                if (Request.QueryString.AllKeys.Contains(field.UniqueName))
                    field.PropertyInfo.SetValue(r, new ActionMapper(DbContext).Map(r, field,
                        field.PropertyType, Request.QueryString.Get(field.UniqueName)));

            return r;
        }
    }
}