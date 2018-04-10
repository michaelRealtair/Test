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
    
    #line 1 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
    using Realtair.Framework.Core.Actions.FieldAttributes;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
    using Realtair.Framework.Core.Entities;
    
    #line default
    #line hidden
    using Realtair.Framework.Core.Interfaces;
    
    #line 3 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
    using Realtair.Framework.Core.Services;
    
    #line default
    #line hidden
    using Realtair.Framework.Core.Web.Utilities;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_RadioButtonGroupField.cshtml")]
    public partial class _Views_Shared_Fields__RadioButtonGroupField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__RadioButtonGroupField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
  
    var attribute = Model.FieldAttribute as RadioButtonGroupFieldAttribute;
    var options = attribute.Options(Model.Action, Html.LoggedInUser());
    var hopefullyUniqueId = Math.Abs(Model.GetHashCode());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">\r\n        <label");

WriteAttribute("class", Tuple.Create(" class=\"", 487), Tuple.Create("\"", 558)
, Tuple.Create(Tuple.Create("", 495), Tuple.Create("control-label", 495), true)
            
            #line 14 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
, Tuple.Create(Tuple.Create(" ", 508), Tuple.Create<System.Object, System.Int32>(Model.Label.Trim().Length == 0 ? "hidden" : ""
            
            #line default
            #line hidden
, 509), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                                                                                  Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container-radiobtn\"");

WriteLiteral(">\r\n            <ul>\r\n");

            
            #line 20 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                 if (options.Count() == 0)
            {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 812), Tuple.Create("\"", 837)
            
            #line 23 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
, Tuple.Create(Tuple.Create("", 819), Tuple.Create<System.Object, System.Int32>(hopefullyUniqueId
            
            #line default
            #line hidden
, 819), false)
);

WriteLiteral(">\r\n                        <label>None to display</label>\r\n                      " +
"  <div");

WriteLiteral(" class=\"radiobtn\"");

WriteLiteral("></div>\r\n                    </li>\r\n");

            
            #line 27 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                }
                else
                {
                    foreach (var option in options)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n");

WriteLiteral("                            ");

            
            #line 33 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                       Write(Html.RadioButton(
                            Model.UniqueName,
                            option.Value.ToString(),
                            option.Value.ToString() == Model.Value?.ToString(),
                            new { id = option.Id.ToString() }
                        ));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1498), Tuple.Create("\"", 1525)
            
            #line 39 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
, Tuple.Create(Tuple.Create("", 1504), Tuple.Create<System.Object, System.Int32>(option.Id.ToString()
            
            #line default
            #line hidden
, 1504), false)
);

WriteLiteral(">");

            
            #line 39 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                                                          Write(option.Description);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n                            <div");

WriteLiteral(" class=\"radiobtn\"");

WriteLiteral("></div>\r\n                        </li>\r\n");

            
            #line 42 "..\..\Views\Shared\Fields\_RadioButtonGroupField.cshtml"
                    }
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
