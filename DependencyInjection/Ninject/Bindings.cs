using Ninject.Modules;
using Realtair.Framework.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtair.Framework.Core.Web.DependencyInjection.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ISingletonDbContext>()
                .To<SingletonDbContext>();
        }
    }
}
