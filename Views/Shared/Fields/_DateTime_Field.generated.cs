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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_DateTime_Field.cshtml")]
    public partial class _Views_Shared_Fields__DateTime_Field_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__DateTime_Field_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
  
    var attribute = Model.FieldAttribute as Realtair.Framework.Core.Actions.FieldAttributes.DateTimeFieldAttribute;
    var Date = Convert.ToDateTime(Model.Value);
    var dateFormat = "yyyy-MM-dd";

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">");

            
            #line 10 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                                     Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <div");

WriteLiteral(" class=\"col-sm-3\"");

WriteLiteral(" id=\"datepicker\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite mydatepicker\"");

WriteAttribute("id", Tuple.Create(" id=\"", 462), Tuple.Create("\"", 484)
            
            #line 12 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
, Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 467), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 485), Tuple.Create("\"", 509)
            
            #line 12 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                    , Tuple.Create(Tuple.Create("", 492), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 492), false)
);

WriteLiteral(" placeholder=\"Click to select date\"");

WriteAttribute("value", Tuple.Create(" value=\"", 545), Tuple.Create("\"", 614)
, Tuple.Create(Tuple.Create("", 553), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 12 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                                                                                                                                                                 if (Date > DateTime.MinValue) { 
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                                                                                                                                                          WriteTo(__razor_attribute_value_writer, Date.ToString(dateFormat));

            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                                                                                                                                                                                                                            }
            
            #line default
            #line hidden
}), 553), false)
);

WriteLiteral(">\r\n");

            
            #line 13 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
            
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
             if (Model.HasError)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 15 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                                    Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 16 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n\r\n");

            
            #line 20 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
 using (Html.Delayed(null))
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://static.realtair.com/plugins/bower_components/bootstrap-datepicker/" +
"bootstrap-datepicker.min.css\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <script");

WriteLiteral(" src=\"https://static.realtair.com/plugins/bower_components/bootstrap-datepicker/b" +
"ootstrap-datepicker.min.js\"");

WriteLiteral("></script>\r\n");

WriteLiteral("    <script>\r\n        $(function () {\r\n            var cal = $(\'#");

            
            #line 26 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
                     Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("\').datepicker({\r\n                format: \'yyyy-mm-dd\',\r\n                startDate" +
": new Date(2000, 0, 1),\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
           Write(Html.Raw(attribute != null && !attribute.AllowPastDates ? "startDate: '+0d'," : ""));

            
            #line default
            #line hidden
WriteLiteral(@"
                autoclose: true,
                clearBtn: true, 
                container: '#datepicker'
            });

            cal.keydown(function (event) {
                if (event.which == 13) { //enter key
                    cal.blur();
                }
            });;

            cal.on('blur', function () {
                if (isNaN(Date.parse($this.val()))) {
                    cal.val('');
                }
            });
        })
    </script>
");

WriteLiteral("    <script>\r\n        $(function () {\r\n            $(\'.mydatepicker\').datepicker(" +
"{\r\n                format: \'yyyy-MM-dd\',\r\n\r\n                startDate: \'+0d\',\r\n " +
"               autoclose: true\r\n            })\r\n        })\r\n    </script>\r\n");

            
            #line 58 "..\..\Views\Shared\Fields\_DateTime_Field.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
