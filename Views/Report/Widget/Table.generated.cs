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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Report/Widget/Table.cshtml")]
    public partial class _Views_Report_Widget_Table_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Entities.Display.TableWidget>
    {
        public _Views_Report_Widget_Table_cshtml()
        {
        }
        public override void Execute()
        {

WriteLiteral("\r\n<div class=\"panel panel-default\">\r\n    <div class=\"panel-heading\">\r\n        <h2" +
">");


            
            #line 5 "..\..\Views\Report\Widget\Table.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n    </div>\r\n\r\n    <div class=\"table-responsive\">\r\n        <table class=\"ta" +
"ble table-striped\" style=\"width: 100%\">\r\n            <thead>\r\n                <t" +
"r>\r\n");


            
            #line 12 "..\..\Views\Report\Widget\Table.cshtml"
                     foreach (var h in Model.Header)
                    {

            
            #line default
            #line hidden
WriteLiteral("                    <th class=\"col-md-");


            
            #line 14 "..\..\Views\Report\Widget\Table.cshtml"
                                 Write(h.ColumnWidth);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 14 "..\..\Views\Report\Widget\Table.cshtml"
                                                 Write(h.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");


            
            #line 15 "..\..\Views\Report\Widget\Table.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");


            
            #line 19 "..\..\Views\Report\Widget\Table.cshtml"
                 foreach (var row in Model.Contents)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n");


            
            #line 22 "..\..\Views\Report\Widget\Table.cshtml"
                     foreach (var item in row)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");


            
            #line 24 "..\..\Views\Report\Widget\Table.cshtml"
                       Write(item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");


            
            #line 25 "..\..\Views\Report\Widget\Table.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");


            
            #line 27 "..\..\Views\Report\Widget\Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 29 "..\..\Views\Report\Widget\Table.cshtml"
                 if (Model.Totals != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr style=\"background: #222; color: #fff;\">\r\n");


            
            #line 32 "..\..\Views\Report\Widget\Table.cshtml"
                     foreach (var item in Model.Totals)
                        {

            
            #line default
            #line hidden
WriteLiteral("                        <td>");


            
            #line 34 "..\..\Views\Report\Widget\Table.cshtml"
                       Write(item);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");


            
            #line 35 "..\..\Views\Report\Widget\Table.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");


            
            #line 37 "..\..\Views\Report\Widget\Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral(@"            </tbody>

            <tfoot>
                <tr class=""visible-xs"">
                    <td colspan=""6"">
                        swipe to see more
                        <i class=""fa fa-long-arrow-right"" aria-hidden=""true""></i>
                    </td>
                    <td></td>
                </tr>
            </tfoot>
        </table>

    </div>
</div>
");


        }
    }
}
#pragma warning restore 1591
