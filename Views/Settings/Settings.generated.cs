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
    
    #line 1 "..\..\Views\Settings\Settings.cshtml"
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Settings/Settings.cshtml")]
    public partial class _Views_Settings_Settings_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Web.Controllers.SettingsController.ViewModel>
    {
        public _Views_Settings_Settings_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Settings\Settings.cshtml"
Write(Html.Partial("Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"page-wrapper\"");

WriteLiteral(" class=\"with-background\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"white-box\"");

WriteLiteral(">\r\n            <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 297), Tuple.Create("\"", 357)
            
            #line 9 "..\..\Views\Settings\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 304), Tuple.Create<System.Object, System.Int32>(Model.Entity.GetDetailsUrl(Html.LoggedInUser(), Url)
            
            #line default
            #line hidden
, 304), false)
);

WriteLiteral(">");

            
            #line 9 "..\..\Views\Settings\Settings.cshtml"
                                                                                             Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</a></h3>\r\n            <div");

WriteLiteral(" class=\"vtabs customvtab\"");

WriteLiteral(">\r\n                <ul");

WriteLiteral(" class=\"nav tabs-vertical\"");

WriteLiteral(">\r\n\r\n");

            
            #line 13 "..\..\Views\Settings\Settings.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Settings\Settings.cshtml"
                     foreach (var setting in Model.Actions)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteAttribute("class", Tuple.Create(" class=\"", 593), Tuple.Create("\"", 721)
, Tuple.Create(Tuple.Create("", 601), Tuple.Create("tab", 601), true)
            
            #line 15 "..\..\Views\Settings\Settings.cshtml"
, Tuple.Create(Tuple.Create(" ", 604), Tuple.Create<System.Object, System.Int32>(setting.Description(Html.LoggedInUser()) == Model.SelectedAction.Description(Html.LoggedInUser()) ? "active" : ""
            
            #line default
            #line hidden
, 605), false)
);

WriteLiteral(">\r\n                            <a");

WriteLiteral(" data-toggle=\"tab\"");

WriteAttribute("href", Tuple.Create(" href=\"", 773), Tuple.Create("\"", 807)
, Tuple.Create(Tuple.Create("", 780), Tuple.Create("#tab-", 780), true)
            
            #line 16 "..\..\Views\Settings\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 785), Tuple.Create<System.Object, System.Int32>(setting.UrlSafeName()
            
            #line default
            #line hidden
, 785), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 17 "..\..\Views\Settings\Settings.cshtml"
                           Write(setting.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n                        </li>\r\n");

            
            #line 20 "..\..\Views\Settings\Settings.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </ul>\r\n                <div");

WriteLiteral(" class=\"tab-content\"");

WriteLiteral(">\r\n");

            
            #line 23 "..\..\Views\Settings\Settings.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\Settings\Settings.cshtml"
                     foreach (var setting in Model.Actions)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteAttribute("id", Tuple.Create(" id=\"", 1152), Tuple.Create("\"", 1183)
, Tuple.Create(Tuple.Create("", 1157), Tuple.Create("tab-", 1157), true)
            
            #line 25 "..\..\Views\Settings\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 1161), Tuple.Create<System.Object, System.Int32>(setting.UrlSafeName()
            
            #line default
            #line hidden
, 1161), false)
);

WriteAttribute("class", Tuple.Create(" class=\"", 1184), Tuple.Create("\"", 1335)
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create("main-form", 1192), true)
, Tuple.Create(Tuple.Create(" ", 1201), Tuple.Create("tab-pane", 1202), true)
, Tuple.Create(Tuple.Create(" ", 1210), Tuple.Create("fade", 1211), true)
, Tuple.Create(Tuple.Create(" ", 1215), Tuple.Create("in", 1216), true)
            
            #line 25 "..\..\Views\Settings\Settings.cshtml"
               , Tuple.Create(Tuple.Create(" ", 1218), Tuple.Create<System.Object, System.Int32>(setting.Description(Html.LoggedInUser()) == Model.SelectedAction.Description(Html.LoggedInUser()) ? "active" : ""
            
            #line default
            #line hidden
, 1219), false)
);

WriteLiteral(">\r\n                            <form");

WriteLiteral(" method=\"post\"");

WriteLiteral(" class=\"form-horizontal\"");

WriteAttribute("action", Tuple.Create(" action=\"", 1410), Tuple.Create("\"", 1496)
, Tuple.Create(Tuple.Create("", 1419), Tuple.Create("/", 1419), true)
            
            #line 26 "..\..\Views\Settings\Settings.cshtml"
 , Tuple.Create(Tuple.Create("", 1420), Tuple.Create<System.Object, System.Int32>(Model.Entity.UrlSafeName()
            
            #line default
            #line hidden
, 1420), false)
, Tuple.Create(Tuple.Create("", 1447), Tuple.Create("/", 1447), true)
            
            #line 26 "..\..\Views\Settings\Settings.cshtml"
                             , Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Model.Entity.Id
            
            #line default
            #line hidden
, 1448), false)
, Tuple.Create(Tuple.Create("", 1464), Tuple.Create("/settings/", 1464), true)
            
            #line 26 "..\..\Views\Settings\Settings.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 1474), Tuple.Create<System.Object, System.Int32>(setting.UrlSafeName()
            
            #line default
            #line hidden
, 1474), false)
);

WriteLiteral(">\r\n");

            
            #line 27 "..\..\Views\Settings\Settings.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\Settings\Settings.cshtml"
                                 if (setting.HasValidated && !setting.IsValid)
                                {
                                    if (setting.Errors.Where(e => e.MemberNames.Count() == 0).Count() > 0)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(">\r\n");

            
            #line 32 "..\..\Views\Settings\Settings.cshtml"
                                            
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Settings\Settings.cshtml"
                                             foreach (var error in setting.Errors.Where(e => e.MemberNames.Count() == 0))
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <p>");

            
            #line 34 "..\..\Views\Settings\Settings.cshtml"
                                              Write(error.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 35 "..\..\Views\Settings\Settings.cshtml"
                                            }

            
            #line default
            #line hidden
WriteLiteral("                                        </div>\r\n");

            
            #line 37 "..\..\Views\Settings\Settings.cshtml"
                                    }
                                }
                                else if (setting == Model.SelectedAction && Model.Submitted)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteLiteral(" class=\"alert alert-success\"");

WriteLiteral(">\r\n                                        <p>Success!</p>\r\n                     " +
"               </div>\r\n");

            
            #line 44 "..\..\Views\Settings\Settings.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 46 "..\..\Views\Settings\Settings.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\Settings\Settings.cshtml"
                                 foreach (var field in setting.Fields)
                                {
                                    var fieldWithReturnType = $"Fields/Settings/_{field.PropertyType.Name}_{field.FieldAttribute.GetType().Name.Substring(0, field.FieldAttribute.GetType().Name.Length - "Attribute".Length)}";
                                    var fieldWithoutReturnType = $"Fields/Settings/_{field.FieldAttribute.GetType().Name.Substring(0, field.FieldAttribute.GetType().Name.Length - "Attribute".Length)}";


            
            #line default
            #line hidden
WriteLiteral("                                    <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

            
            #line 52 "..\..\Views\Settings\Settings.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Settings\Settings.cshtml"
                                         if (Html.ViewExists(fieldWithReturnType))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Settings\Settings.cshtml"
                                       Write(Html.Partial(fieldWithReturnType, field));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Settings\Settings.cshtml"
                                                                                     ;
                                        }
                                        else if (Html.ViewExists(fieldWithoutReturnType))
                                        {
                                            
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Settings\Settings.cshtml"
                                       Write(Html.Partial(fieldWithoutReturnType, field));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Settings\Settings.cshtml"
                                                                                        ;
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <p>Cannot render field view, looked f" +
"or both ");

            
            #line 62 "..\..\Views\Settings\Settings.cshtml"
                                                                                    Write(fieldWithReturnType);

            
            #line default
            #line hidden
WriteLiteral(" and ");

            
            #line 62 "..\..\Views\Settings\Settings.cshtml"
                                                                                                             Write(fieldWithoutReturnType);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 63 "..\..\Views\Settings\Settings.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </div>\r\n");

            
            #line 65 "..\..\Views\Settings\Settings.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <input");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\"", 4120), Tuple.Create("\"", 4169)
            
            #line 66 "..\..\Views\Settings\Settings.cshtml"
, Tuple.Create(Tuple.Create("", 4128), Tuple.Create<System.Object, System.Int32>(setting.Description(Html.LoggedInUser())
            
            #line default
            #line hidden
, 4128), false)
);

WriteLiteral(" class=\"btn btn-primary pull-right\"");

WriteLiteral(">\r\n                            </form>\r\n                        </div>\r\n");

            
            #line 69 "..\..\Views\Settings\Settings.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 75 "..\..\Views\Settings\Settings.cshtml"
Write(Html.Partial("Footer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 77 "..\..\Views\Settings\Settings.cshtml"
Write(Html.RenderDelayed());

            
            #line default
            #line hidden
WriteLiteral("\r\n");

});

        }
    }
}
#pragma warning restore 1591
