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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/Settings/_CheckboxField.cshtml")]
    public partial class _Views_Shared_Fields_Settings__CheckboxField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields_Settings__CheckboxField_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 3 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
  
    var attribute = Model.FieldAttribute as Realtair.Framework.Core.Actions.FieldAttributes.CheckboxFieldAttribute;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 9 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n");

            
            #line 11 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
      

        if (Model.PropertyType.Name == "Nullable`1")
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(" style=\"padding-top: 8px;\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 539), Tuple.Create("\"", 563)
            
            #line 17 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 546), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral("> ");

            
            #line 17 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                          Write(attribute.LabelForTrue);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n                </label>\r\n                <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 719), Tuple.Create("\"", 743)
            
            #line 20 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 726), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 726), false)
);

WriteLiteral(" value=\"false\"");

WriteLiteral("> ");

            
            #line 20 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                           Write(attribute.LabelForFalse);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n                </label>\r\n            </div>\r\n");

            
            #line 23 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(" style=\"padding-top: 8px;\"");

WriteLiteral(">\r\n                <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1028), Tuple.Create("\"", 1052)
            
            #line 28 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 1035), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1035), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 28 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                          Write(Convert.ToBoolean(Model.Value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral("> ");

            
            #line 28 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                                                                                       Write(attribute.LabelForTrue);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n                </label>\r\n                <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1269), Tuple.Create("\"", 1293)
            
            #line 31 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 1276), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1276), false)
);

WriteLiteral(" value=\"false\"");

WriteLiteral(" ");

            
            #line 31 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                           Write(!Convert.ToBoolean(Model.Value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral("> ");

            
            #line 31 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
                                                                                                                                         Write(attribute.LabelForFalse);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n                </label>\r\n            </div>\r\n");

            
            #line 34 "..\..\Views\Shared\Fields\Settings\_CheckboxField.cshtml"
        }
    
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n   \r\n</div>");

        }
    }
}
#pragma warning restore 1591
