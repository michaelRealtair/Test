using Realtair.Framework.Core.Data;
using Realtair.Framework.Core.Reflection;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Realtair.Framework.Core.Web.Utilities.ConfigureSingleton), "Start")]
namespace Realtair.Framework.Core.Web.Utilities
{
    public static class ConfigureSingleton
    {
        public static void Start()
        {
            var singleton = new Singleton();
            SingletonDbContext.Instance = singleton;
            SingletonAssemblyCache.Instance = singleton;
        }
    }
}
