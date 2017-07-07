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
        static DbContext dbContext;
        public DbContext DbContext
        {
            get
            {
                var a = ConfigurationManager.AppSettings["CoreAssembly"];
                var c = ConfigurationManager.AppSettings["CoreContext"];
         
                if (HttpContext.Current != null)
                {
                    if (!HttpContext.Current.Items.Contains("dbContext"))
                    {                        

                        HttpContext.Current.Items.Add("dbContext", (DbContext)Activator.CreateInstance(a, c).Unwrap());
                    }
                    return HttpContext.Current.Items["dbContext"] as DbContext;
                }
                else
                {                    
                    if (dbContext == null) 
                        dbContext = (DbContext)Activator.CreateInstance(a, c).Unwrap();
                    return dbContext;
                }                
            }
        }
    }
}
