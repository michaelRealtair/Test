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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_OptionsField.cshtml")]
    public partial class _Views_Shared_Fields__OptionsField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__OptionsField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
  
    var attribute = Model.FieldAttribute as Realtair.Framework.Core.Actions.FieldAttributes.OptionsFieldAttribute;
    var options = attribute.Options(Model.Action, Html.LoggedInUser());
    var hopefullyUniqueId = Math.Abs(Model.GetHashCode());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
     if (Model.Label.Count() > 40)
    {
            
            #line default
            #line hidden
WriteLiteral("    <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                                          Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

            
            #line 12 "..\..\Views\Shared\Fields\_OptionsField.cshtml"

    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">");

            
            #line 16 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                                         Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n");

            
            #line 17 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(">\r\n");

            
            #line 19 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
         if (options.Count() == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <select");

WriteAttribute("id", Tuple.Create(" id=\"", 632), Tuple.Create("\"", 655)
            
            #line 21 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 637), Tuple.Create<System.Object, System.Int32>(hopefullyUniqueId
            
            #line default
            #line hidden
, 637), false)
);

WriteLiteral(" class=\"form-control lite\"");

WriteLiteral(" disabled>\r\n                <option>None to display</option>\r\n            </selec" +
"t>\r\n");

            
            #line 24 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <select");

WriteAttribute("id", Tuple.Create(" id=\"", 822), Tuple.Create("\"", 845)
            
            #line 27 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 827), Tuple.Create<System.Object, System.Int32>(hopefullyUniqueId
            
            #line default
            #line hidden
, 827), false)
);

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("name", Tuple.Create(" name=\"", 872), Tuple.Create("\"", 896)
            
            #line 27 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 879), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 879), false)
);

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                 foreach (var option in options)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option ");

            
            #line 30 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                        Write(option.Id.ToString() == Model.FormValue?.ToString() ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 30 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                                                                                                       Write(option.Id.ToString());

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 30 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                                                                                                                              Write(option.Description);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 31 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </select>\r\n");

            
            #line 33 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <script");

WriteLiteral(" src=\"https://static.realtair.com/plugins/select2/js/select2.min.js\"");

WriteLiteral("></script>\r\n        <script>\r\n            $(window).resize(function () {\r\n       " +
"         $(\'.select2\').css(\'width\', \"100%\");\r\n            });\r\n\r\n    \t    $(\'#");

            
            #line 41 "..\..\Views\Shared\Fields\_OptionsField.cshtml"
            Write(hopefullyUniqueId);

            
            #line default
            #line hidden
WriteLiteral("\').select2();\r\n        </script>\r\n    </div>\r\n</div>\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
