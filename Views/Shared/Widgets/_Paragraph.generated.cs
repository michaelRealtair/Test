﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Realtair.Framework.Core.Actions;
    using Realtair.Framework.Core.Entities;
    using Realtair.Framework.Core.Interfaces;
    using Realtair.Framework.Core.Web.Utilities;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Widgets/_Paragraph.cshtml")]
    public partial class _Views_Shared_Widgets__Paragraph_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Entities.Display.ParagraphWidget>
    {
        public _Views_Shared_Widgets__Paragraph_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <h3>");

            
            #line 3 "..\..\Views\Shared\Widgets\_Paragraph.cshtml"
   Write(Model.Text);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
