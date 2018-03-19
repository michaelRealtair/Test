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
    using System.Collections;
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Widgets/_Actions.cshtml")]
    public partial class _Views_Shared_Widgets__Actions_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Entities.Display.ActionsWidget>
    {
        public _Views_Shared_Widgets__Actions_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n");

            
            #line 4 "..\..\Views\Shared\Widgets\_Actions.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Shared\Widgets\_Actions.cshtml"
     if (!string.IsNullOrEmpty(Model.Name))
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">Model.Name</div>\r\n");

            
            #line 7 "..\..\Views\Shared\Widgets\_Actions.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"panel-wrapper collapse in\"");

WriteLiteral(" style=\"margin-bottom: 10px;\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Shared\Widgets\_Actions.cshtml"
        
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Shared\Widgets\_Actions.cshtml"
         foreach (var action in Model.Actions)
        {
            var user = Html.LoggedInUser();
            var db = action.Db;

            if (action.AccessibleTo(user, db))
            {

            
            #line default
            #line hidden
WriteLiteral("                <!-- Action Buttons -->\r\n");

WriteLiteral("                <form");

WriteLiteral(" class=\"inline\"");

WriteAttribute("action", Tuple.Create(" action=\"", 537), Tuple.Create("\"", 565)
            
            #line 17 "..\..\Views\Shared\Widgets\_Actions.cshtml"
, Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(action.GetUrl(Url)
            
            #line default
            #line hidden
, 546), false)
);

WriteAttribute("method", Tuple.Create(" method=\"", 566), Tuple.Create("\"", 621)
            
            #line 17 "..\..\Views\Shared\Widgets\_Actions.cshtml"
, Tuple.Create(Tuple.Create("", 575), Tuple.Create<System.Object, System.Int32>(action.Fields.Count() >= 1 ? "GET" : "POST"
            
            #line default
            #line hidden
, 575), false)
);

WriteLiteral(">\r\n                    <input autofocus");

WriteLiteral(" name=\"ReturnUrl\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 692), Tuple.Create("\"", 725)
            
            #line 18 "..\..\Views\Shared\Widgets\_Actions.cshtml"
, Tuple.Create(Tuple.Create("", 700), Tuple.Create<System.Object, System.Int32>(Request.Url.AbsolutePath
            
            #line default
            #line hidden
, 700), false)
);

WriteLiteral(" />\r\n                    <button");

WriteLiteral(" class=\"btn btn-sm btn-info btn-outline btn-rounded m-l-10 m-b-10\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 19 "..\..\Views\Shared\Widgets\_Actions.cshtml"
                                                                                                       Write(action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                </form>\r\n");

WriteLiteral("                <!-- End of Action Buttons -->\r\n");

            
            #line 22 "..\..\Views\Shared\Widgets\_Actions.cshtml"
            }
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
