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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/Settings/_DetailWidget_WidgetField.cshtml")]
    public partial class _Views_Shared_Fields_Settings__DetailWidget_WidgetField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields_Settings__DetailWidget_WidgetField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
  
    var widget = Model.Value as Realtair.Framework.Core.Entities.Display.DetailWidget;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"panel\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                          Write(widget.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"panel-wrapper collapse in\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n            <tbody>\r\n");

            
            #line 12 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                 foreach (var describable in widget.Details)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <th");

WriteLiteral(" class=\"col-sm-4 p-l-40\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                                               Write(describable.Key);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n                        <td");

WriteLiteral(" data-key=\"");

            
            #line 16 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                                 Write(describable.Key);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 17 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                       Write(Html.Render(Url, describable.Value));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");

            
            #line 20 "..\..\Views\Shared\Fields\Settings\_DetailWidget_WidgetField.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
