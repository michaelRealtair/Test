using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Realtair.Framework.Core.Web.DependencyInjection
{
    public static class KernelWrapper
    {
        // Fields
        private static StandardKernel kernel;

        // Props
        public static StandardKernel Kernel
        {
            get
            {
                if (kernel == null)
                {
                    kernel = new StandardKernel();
                    kernel.Load(Assembly.GetEntryAssembly());
                }
                return kernel;
            }
        }

        // Methods
        public static T Get<T>()
        {
            return kernel.Get<T>();
        }
    }
}
