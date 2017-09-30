using Realtair.Framework.Core.Data;
using Realtair.Framework.Core.Reflection;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Reflection;
using System.Web;

namespace Realtair.Framework.Core.Web
{
    public class Singleton : ISingletonDbContext, ISingletonAssemblyCache
    {
        // Constant Fields
        private const string KEY_DB_CONTEXT = "DB_CONTEXT";
        private const string KEY_ASSEMBLY_CACHE = "ASSEMBLY_CACHE";

        // Fields
        private static string coreAssembly = ConfigurationManager.AppSettings["CoreAssembly"];
        private static string coreContext = ConfigurationManager.AppSettings["CoreContext"];
        private static DbContext _dbContext;
        private static AssemblyCache _assemblyCache;

        // Properties
        public DbContext DbContext
        {
            get
            {
                var dbContext = Activator
                    .CreateInstance(coreAssembly, coreContext)
                    .Unwrap() as DbContext;

                if (HttpContext.Current != null)
                {
                    return SetHttpContextItem(KEY_DB_CONTEXT, dbContext);
                }
                else
                {
                    if (_dbContext == null)
                        _dbContext = dbContext;
                    return _dbContext;
                }                
            }
        }
        public AssemblyCache AssemblyCache
        {
            get
            {
                var assemblyCache = new AssemblyCache(Assembly.Load(coreAssembly));

                if (HttpContext.Current != null)
                {
                    return SetHttpContextItem(KEY_ASSEMBLY_CACHE, assemblyCache);
                }
                else
                {
                    if (_assemblyCache == null)
                        _assemblyCache = assemblyCache;

                    return _assemblyCache;
                }
            }
        }

        // Methods
        private T SetHttpContextItem<T>(string key, T t) where T : class
        {
            T value = null;
            var context = HttpContext.Current;

            if (context != null)
            {
                if (!context.Items.Contains(key))
                    context.Items.Add(key, t);

                 value = context.Items[key] as T;
            }

            return value;
        }
    }
}
