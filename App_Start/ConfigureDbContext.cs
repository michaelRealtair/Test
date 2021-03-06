﻿using Realtair.Framework.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Realtair.Framework.Core.Web.Utilities.ConfigureDbContext), "Start")]
namespace Realtair.Framework.Core.Web.Utilities
{
    public static class ConfigureDbContext
    {
        public static void Start()
        {
            Data.SingletonDbContext.Instance = new Singleton();
        }
    }
}
