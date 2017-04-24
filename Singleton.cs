using Realtair.Framework.Core.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Realtair.Framework.Core.Web
{
    public class Singleton : ISingletonDbContext
    {
        public DbContext DbContext
        {
            get
            {
                if (!HttpContext.Current.Items.Contains("dbContext"))
                {
                    var a = ConfigurationManager.AppSettings["CoreAssembly"];
                    var c = ConfigurationManager.AppSettings["CoreContext"];

                    HttpContext.Current.Items.Add("dbContext", (DbContext)Activator.CreateInstance(a, c).Unwrap());
                }
                return HttpContext.Current.Items["dbContext"] as DbContext;
            }
        }
    }
}
