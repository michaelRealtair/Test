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
    
    #line 3 "..\..\Views\Shared\Widgets\_Table.cshtml"
    using System.Text.RegularExpressions;
    
    #line default
    #line hidden
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
    
    #line 1 "..\..\Views\Shared\Widgets\_Table.cshtml"
    using Realtair.Framework.Core.Interfaces;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\Widgets\_Table.cshtml"
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
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

            
            #line 7 "..\..\Views\Shared\Widgets\_Table.cshtml"
                          Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n    <div");

WriteLiteral(" class=\"panel-wrapper collapse in\"");

WriteLiteral(">\r\n        <table");

WriteLiteral(" class=\"table\"");

WriteLiteral(">\r\n");

            
            #line 10 "..\..\Views\Shared\Widgets\_Table.cshtml"
            
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Shared\Widgets\_Table.cshtml"
             if (Model.Header != null)
            {

            
            #line default
            #line hidden
WriteLiteral("            <thead>\r\n                <tr>                \r\n");

            
            #line 14 "..\..\Views\Shared\Widgets\_Table.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Shared\Widgets\_Table.cshtml"
                     foreach (var column in Model.Header)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <th");

WriteAttribute("class", Tuple.Create(" class=\"", 575), Tuple.Create("\"", 705)
, Tuple.Create(Tuple.Create("", 583), Tuple.Create("col-xs-", 583), true)
            
            #line 16 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 590), Tuple.Create<System.Object, System.Int32>(column.ColumnWidth
            
            #line default
            #line hidden
, 590), false)
, Tuple.Create(Tuple.Create(" ", 611), Tuple.Create("col-sm-", 612), true)
            
            #line 16 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 619), Tuple.Create<System.Object, System.Int32>(column.ColumnWidth
            
            #line default
            #line hidden
, 619), false)
, Tuple.Create(Tuple.Create(" ", 640), Tuple.Create("col-md-", 641), true)
            
            #line 16 "..\..\Views\Shared\Widgets\_Table.cshtml"
                      , Tuple.Create(Tuple.Create("", 648), Tuple.Create<System.Object, System.Int32>(column.ColumnWidth
            
            #line default
            #line hidden
, 648), false)
, Tuple.Create(Tuple.Create(" ", 669), Tuple.Create("col-lg-", 670), true)
            
            #line 16 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 677), Tuple.Create<System.Object, System.Int32>(column.ColumnWidth
            
            #line default
            #line hidden
, 677), false)
, Tuple.Create(Tuple.Create(" ", 698), Tuple.Create("p-l-40", 699), true)
);

WriteLiteral(">");

            
            #line 16 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                                                                                                                                          Write(column.Name);

            
            #line default
            #line hidden
WriteLiteral("</th>\r\n");

            
            #line 17 "..\..\Views\Shared\Widgets\_Table.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n            </thead>\r\n");

            
            #line 20 "..\..\Views\Shared\Widgets\_Table.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <tbody>\r\n");

            
            #line 22 "..\..\Views\Shared\Widgets\_Table.cshtml"
                
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\Widgets\_Table.cshtml"
                 foreach (var row in Model.Contents)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n");

            
            #line 25 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\Widgets\_Table.cshtml"
                         foreach (var column in row)
                        {
                            if (column is Attachment)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1149), Tuple.Create("\"", 1196)
            
            #line 29 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 1156), Tuple.Create<System.Object, System.Int32>(Html.Raw((column as Attachment).Url(0))
            
            #line default
            #line hidden
, 1156), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">View</a></td>\r\n");

            
            #line 30 "..\..\Views\Shared\Widgets\_Table.cshtml"
                            }
                            else if (column is IDisplayable)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral(">");

            
            #line 33 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                              Write(Html.Render(Url, column));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 34 "..\..\Views\Shared\Widgets\_Table.cshtml"
                            }
                            else if (column.ToString().IsValidUrl())
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1621), Tuple.Create("\"", 1635)
            
            #line 37 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 1628), Tuple.Create<System.Object, System.Int32>(column
            
            #line default
            #line hidden
, 1628), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">View</a></td>\r\n");

            
            #line 38 "..\..\Views\Shared\Widgets\_Table.cshtml"
                            }
                            else if (column is KeyValuePair<string, IDisplayable>)
                            {                                
                                var keyObj = column.GetType().GetProperty("Key").GetValue(column, null);
                                var valueObj = column.GetType().GetProperty("Value").GetValue(column, null);


            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 2117), Tuple.Create("\"", 2193)
            
            #line 44 "..\..\Views\Shared\Widgets\_Table.cshtml"
, Tuple.Create(Tuple.Create("", 2124), Tuple.Create<System.Object, System.Int32>((valueObj as IDisplayable).GetDetailsUrl(Html.LoggedInUser(), Url)
            
            #line default
            #line hidden
, 2124), false)
);

WriteLiteral(">");

            
            #line 44 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                                                                                                              Write(keyObj);

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n");

            
            #line 45 "..\..\Views\Shared\Widgets\_Table.cshtml"
                            }

                            
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\Widgets\_Table.cshtml"
                               
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                    <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral(">");

            
            #line 53 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                                  Write(column);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 54 "..\..\Views\Shared\Widgets\_Table.cshtml"
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\r\n");

            
            #line 57 "..\..\Views\Shared\Widgets\_Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 59 "..\..\Views\Shared\Widgets\_Table.cshtml"
                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Shared\Widgets\_Table.cshtml"
                 if (Model.Totals != null)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteLiteral(" class=\"bg-inverse text-white\"");

WriteLiteral(">\r\n");

            
            #line 62 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Shared\Widgets\_Table.cshtml"
                         foreach (var total in Model.Totals)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <td");

WriteLiteral(" class=\"p-l-40\"");

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 65 "..\..\Views\Shared\Widgets\_Table.cshtml"
                           Write(total);

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </td>\r\n");

            
            #line 67 "..\..\Views\Shared\Widgets\_Table.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </tr>\r\n");

            
            #line 69 "..\..\Views\Shared\Widgets\_Table.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
