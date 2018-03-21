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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_TableWidget_WidgetField.cshtml")]
    public partial class _Views_Shared_Fields__TableWidget_WidgetField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__TableWidget_WidgetField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
  
    var tableWidget = Model.Value as Realtair.Framework.Core.Entities.Display.TableWidget;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 7 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
 if (tableWidget != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"table color-bordered-table muted-bordered-table margin-b-md\"");

WriteLiteral(" style=\"width: 100%\"");

WriteLiteral(">\r\n        <thead>\r\n            <tr >\r\n");

            
            #line 12 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                 foreach (var h in tableWidget.Header)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th");

WriteAttribute("class", Tuple.Create(" class=\"", 414), Tuple.Create("\"", 460)
, Tuple.Create(Tuple.Create("", 422), Tuple.Create("col-md-", 422), true)
            
            #line 14 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
, Tuple.Create(Tuple.Create("", 429), Tuple.Create<System.Object, System.Int32>(h.ColumnWidth
            
            #line default
            #line hidden
, 429), false)
, Tuple.Create(Tuple.Create(" ", 443), Tuple.Create("table-header-pad", 444), true)
);

WriteLiteral("><h3");

WriteLiteral(" class=\"no-margin\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                                                                                        Write(h.Name);

            
            #line default
            #line hidden
WriteLiteral("</h3></th>\r\n");

            
            #line 15 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");

            
            #line 19 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
            
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
             foreach (var row in tableWidget.Contents)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr >\r\n");

            
            #line 22 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                         foreach (var item in row)
                        {
                            if (item is Attachment)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"td-nopad-lft\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 892), Tuple.Create("\"", 937)
            
            #line 26 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
, Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(Html.Raw((item as Attachment).Url(0))
            
            #line default
            #line hidden
, 899), false)
);

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">");

            
            #line 26 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                                                                                                                      Write((item as Attachment).Url(0));

            
            #line default
            #line hidden
WriteLiteral("</a></td>\r\n");

            
            #line 27 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <td");

WriteLiteral(" class=\"td-nopad-lft\"");

WriteLiteral("><h4");

WriteLiteral(" class=\"no-margin l-h-xl\"");

WriteLiteral(">");

            
            #line 30 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                                                                                 Write(item);

            
            #line default
            #line hidden
WriteLiteral("</h4></td>\r\n");

            
            #line 31 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                \r\n            </tr>\r\n");

            
            #line 35 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 37 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
            
            
            #line default
            #line hidden
            
            #line 37 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
             if (tableWidget.Totals != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" style=\"background: #222; color: #fff;\"");

WriteLiteral(">\r\n");

            
            #line 40 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                     foreach (var item in tableWidget.Totals)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td><h4");

WriteLiteral(" class=\"no-margin l-h-md\"");

WriteLiteral("><b>");

            
            #line 42 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                                                       Write(item);

            
            #line default
            #line hidden
WriteLiteral("</b></h4></td>\r\n");

            
            #line 43 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");

            
            #line 45 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tbody>\r\n    </table>\r\n");

            
            #line 48 "..\..\Views\Shared\Fields\_TableWidget_WidgetField.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
