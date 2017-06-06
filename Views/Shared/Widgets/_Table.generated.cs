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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Widgets/_Table.cshtml")]
    public partial class _Views_Shared_Widgets__Table_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Entities.Display.TableWidget>
    {
        public _Views_Shared_Widgets__Table_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">");

            
            #line 3 "..\..\Views\Shared\Widgets\_Table.cshtml"
                          Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"panel-wrapper collapse in\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table table-responsive\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>                \r\n");

            
            #line 8 "..\..\Views\Shared\Widgets\_Table.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 8 "..\..\Views\Shared\Widgets\_Table.cshtml"
                     foreach (var column in Model.Header)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <th");

WriteAttribute("class", Tuple.Create(" class=\"", 407), Tuple.Create("\"", 443)
, Tuple.Create(Tuple.Create("", 415), Tuple.Create("col-xs-", 415), true)
            
            #line 10 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 422), Tuple.Create<System.Object, System.Int32>(column.ColumnWidth
            
            #line default
            #line hidden
, 422), false)
);

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                                            Write(column.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 11 "..\..\Views\Shared\Widgets\_Table.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 15 "..\..\Views\Shared\Widgets\_Table.cshtml"
                
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\Widgets\_Table.cshtml"
                 foreach (var row in Model.Contents)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n");

            
            #line 18 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 18 "..\..\Views\Shared\Widgets\_Table.cshtml"
                         foreach (var column in row)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td>");

            
            #line 20 "..\..\Views\Shared\Widgets\_Table.cshtml"
                           Write(column);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 21 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\r\n");

            
            #line 23 "..\..\Views\Shared\Widgets\_Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 25 "..\..\Views\Shared\Widgets\_Table.cshtml"
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\Widgets\_Table.cshtml"
                 if (Model.Totals != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteLiteral(" class=\"bg-inverse text-white\"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Shared\Widgets\_Table.cshtml"
                         foreach (var total in Model.Totals)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td>\r\n");

WriteLiteral("                                ");

            
            #line 31 "..\..\Views\Shared\Widgets\_Table.cshtml"
                           Write(total);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </td>\r\n");

            
            #line 33 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\r\n");

            
            #line 35 "..\..\Views\Shared\Widgets\_Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
