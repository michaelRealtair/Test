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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/Settings/_String_PasswordField.cshtml")]
    public partial class _Views_Shared_Fields_Settings__String_PasswordField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields_Settings__String_PasswordField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
 if (Model.HasError)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group has-error\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 7 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n            <input");

WriteAttribute("name", Tuple.Create(" name=\"", 294), Tuple.Create("\"", 318)
            
            #line 11 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
, Tuple.Create(Tuple.Create("", 301), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 301), false)
);

WriteLiteral(" type=\"password\"");

WriteLiteral(" placeholder=\"...\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" value=\"\"");

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
                                Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");

            
            #line 15 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n            <input");

WriteAttribute("name", Tuple.Create(" name=\"", 702), Tuple.Create("\"", 726)
            
            #line 24 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
, Tuple.Create(Tuple.Create("", 709), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 709), false)
);

WriteLiteral(" type=\"password\"");

WriteLiteral(" placeholder=\"...\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n");

            
            #line 27 "..\..\Views\Shared\Fields\Settings\_String_PasswordField.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
