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

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 8 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(" style=\"padding-top: 8px;\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 440), Tuple.Create("\"", 471)
            
            #line 13 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 447), Tuple.Create<System.Object, System.Int32>(Model.PropertyInfo.Name
            
            #line default
            #line hidden
, 447), false)
);

WriteLiteral(" value=\"true\"");

WriteLiteral(" ");

            
            #line 13 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                         Write(Convert.ToBoolean(Model.Value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral("> ");

            
            #line 13 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                                                      Write(attribute.LabelForTrue);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n        </label>\r\n        <label");

WriteLiteral(" class=\"radio-inline\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 664), Tuple.Create("\"", 695)
            
            #line 16 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
, Tuple.Create(Tuple.Create("", 671), Tuple.Create<System.Object, System.Int32>(Model.PropertyInfo.Name
            
            #line default
            #line hidden
, 671), false)
);

WriteLiteral(" value=\"false\"");

WriteLiteral(" ");

            
            #line 16 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                          Write(!Convert.ToBoolean(Model.Value) ? "checked='checked'" : "");

            
            #line default
            #line hidden
WriteLiteral("> ");

            
            #line 16 "..\..\Views\Shared\Fields\_CheckboxField.cshtml"
                                                                                                                                        Write(attribute.LabelForFalse);

            
            #line default
            #line hidden
WriteLiteral("<br>\r\n        </label>\r\n    </div>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
