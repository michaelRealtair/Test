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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_TimeSpan_Field.cshtml")]
    public partial class _Views_Shared_Fields__TimeSpan_Field_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__TimeSpan_Field_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 5 "..\..\Views\Shared\Fields\_TimeSpan_Field.cshtml"
                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n        <input");

WriteAttribute("name", Tuple.Create(" name=\"", 235), Tuple.Create("\"", 259)
            
            #line 9 "..\..\Views\Shared\Fields\_TimeSpan_Field.cshtml"
, Tuple.Create(Tuple.Create("", 242), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 242), false)
);

WriteLiteral(" type=\"time\"");

WriteAttribute("value", Tuple.Create(" value=\"", 272), Tuple.Create("\"", 306)
            
            #line 9 "..\..\Views\Shared\Fields\_TimeSpan_Field.cshtml"
, Tuple.Create(Tuple.Create("", 280), Tuple.Create<System.Object, System.Int32>(((TimeSpan)Model.Value)
            
            #line default
            #line hidden
, 280), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" onchange=\"validateTimespan(this);\"");

WriteLiteral(">\r\n    </div>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
