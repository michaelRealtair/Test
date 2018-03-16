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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_CheckboxField.cshtml")]
    public partial class _Views_Shared_Fields__CheckboxField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__CheckboxField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
  
    var attribute = Model.FieldAttribute as Realtair.Framework.Core.Actions.FieldAttributes.CheckboxFieldAttribute;
    var propertyname = Model.PropertyInfo.Name;
    var value = Model.Value;
    var trueCheckboxName = $"{propertyname}-true";
    var falseCheckboxName = $"{propertyname}-false";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

            
            #line 11 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
     if (Model.Label.Count() > 40)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-sm-4 control-label\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n");

            
            #line 16 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-sm-6\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <p>\r\n                    <label>\r\n                        <inp" +
"ut");

WriteAttribute("id", Tuple.Create(" id=\"", 701), Tuple.Create("\"", 723)
            
            #line 21 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 706), Tuple.Create<System.Object, System.Int32>(trueCheckboxName
            
            #line default
            #line hidden
, 706), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 740), Tuple.Create("\"", 760)
            
            #line 21 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 747), Tuple.Create<System.Object, System.Int32>(propertyname
            
            #line default
            #line hidden
, 747), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 21 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                    Write(Convert.ToBoolean(value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"checkbox-material\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"check\"");

WriteLiteral(">\r\n                            </span>\r\n                        </span>\r\n");

WriteLiteral("                        ");

            
            #line 26 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                   Write(attribute.LabelForTrue);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </label>\r\n                </p>\r\n            </div>\r\n       " +
"     &nbsp;\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <p>\r\n                    <label>\r\n                        <inp" +
"ut");

WriteAttribute("id", Tuple.Create(" id=\"", 1267), Tuple.Create("\"", 1290)
            
            #line 34 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 1272), Tuple.Create<System.Object, System.Int32>(falseCheckboxName
            
            #line default
            #line hidden
, 1272), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1307), Tuple.Create("\"", 1327)
            
            #line 34 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(propertyname
            
            #line default
            #line hidden
, 1314), false)
);

WriteLiteral(" value=\"false\"");

WriteLiteral(" ");

            
            #line 34 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                      Write(!Convert.ToBoolean(value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"checkbox-material\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"check\"");

WriteLiteral(">\r\n                            </span>\r\n                        </span>\r\n");

WriteLiteral("                        ");

            
            #line 39 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                   Write(attribute.LabelForFalse);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </label>\r\n                </p>\r\n            </div>\r\n       " +
" </div>\r\n");

            
            #line 44 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 48 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n");

WriteLiteral("        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <p>\r\n                    <label>\r\n                        <inp" +
"ut");

WriteAttribute("id", Tuple.Create(" id=\"", 2014), Tuple.Create("\"", 2036)
            
            #line 54 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 2019), Tuple.Create<System.Object, System.Int32>(trueCheckboxName
            
            #line default
            #line hidden
, 2019), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2053), Tuple.Create("\"", 2073)
            
            #line 54 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(propertyname
            
            #line default
            #line hidden
, 2060), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 54 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                    Write(Convert.ToBoolean(value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"checkbox-material\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"check\"");

WriteLiteral(">\r\n                            </span>\r\n                        </span>\r\n");

WriteLiteral("                        ");

            
            #line 59 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                   Write(attribute.LabelForTrue);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </label>\r\n                </p>\r\n            </div>\r\n       " +
"     &nbsp;\r\n            <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n                <p>\r\n                    <label>\r\n                        <inp" +
"ut");

WriteAttribute("id", Tuple.Create(" id=\"", 2580), Tuple.Create("\"", 2603)
            
            #line 67 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 2585), Tuple.Create<System.Object, System.Int32>(falseCheckboxName
            
            #line default
            #line hidden
, 2585), false)
);

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2620), Tuple.Create("\"", 2640)
            
            #line 67 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 2627), Tuple.Create<System.Object, System.Int32>(propertyname
            
            #line default
            #line hidden
, 2627), false)
);

WriteLiteral(" value=\"false\"");

WriteLiteral(" ");

            
            #line 67 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                      Write(!Convert.ToBoolean(value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"checkbox-material\"");

WriteLiteral(">\r\n                            <span");

WriteLiteral(" class=\"check\"");

WriteLiteral(">\r\n                            </span>\r\n                        </span>\r\n");

WriteLiteral("                        ");

            
            #line 72 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                   Write(attribute.LabelForFalse);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </label>\r\n                </p>\r\n            </div>\r\n       " +
" </div>\r\n");

            
            #line 77 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n</div>\r\n\r\n<script>\r\n    (function () {\r\n        var trueCheckbox = $(\'input#");

            
            #line 84 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                               Write(trueCheckboxName);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n        var falseCheckbox = $(\'input#");

            
            #line 85 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                Write(falseCheckboxName);

            
            #line default
            #line hidden
WriteLiteral(@"');

        trueCheckbox.change(function () {
            falseCheckbox.prop('checked', !$(this).prop('checked'));
        });

        falseCheckbox.change(function () {
            trueCheckbox.prop('checked', !$(this).prop('checked'));
        });
    })();
</script>");

        }
    }
}
#pragma warning restore 1591
