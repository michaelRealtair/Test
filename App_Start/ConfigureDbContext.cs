using Realtair.Framework.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using Ninject;
using System.Configuration;
using Realtair.Framework.Core.Web.DependencyInjection;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Realtair.Framework.Core.Web.ConfigureDbContext), "Start")]
namespace Realtair.Framework.Core.Web
{
    public static class ConfigureDbContext
    {
        public static void Start()
        {
            using (var kernel = new StandardKernel())
            {
                Data.SingletonDbContext.Instance = KernelWrapper.Get<ISingletonDbContext>();
            }
        }
    }
}
