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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_MultiSelectOptionsField.cshtml")]
    public partial class _Views_Shared_Fields__MultiSelectOptionsField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__MultiSelectOptionsField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
  
    var attribute = Model.FieldAttribute as Realtair.Framework.Core.Actions.FieldAttributes.MultiSelectOptionsFieldAttribute;
    var options = attribute.Options(Model.Action, Html.LoggedInUser());
    var hopefullyUniqueId = Math.Abs(Model.GetHashCode());
    //var Values = (Model.Value as IEnumerable<Entity>).ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
         if (options.Count() == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <select");

WriteAttribute("id", Tuple.Create(" id=\"", 623), Tuple.Create("\"", 646)
            
            #line 18 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 628), Tuple.Create<System.Object, System.Int32>(hopefullyUniqueId
            
            #line default
            #line hidden
, 628), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" disabled>\r\n                <option>None to display</option>\r\n            </selec" +
"t>\r\n");

            
            #line 21 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <select");

WriteAttribute("id", Tuple.Create(" id=\"", 808), Tuple.Create("\"", 831)
            
            #line 24 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 813), Tuple.Create<System.Object, System.Int32>(hopefullyUniqueId
            
            #line default
            #line hidden
, 813), false)
);

WriteLiteral(" class=\"form-control select2-multiple\"");

WriteLiteral(" multiple=\"multiple\"");

WriteLiteral(">\r\n");

            
            #line 25 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                
            
            #line default
            #line hidden
            
            #line 25 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                 foreach (var option in options)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option ");

            
            #line 27 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                        Write((Model.Value as IEnumerable<Entity>).Where(a => a.Id.ToString() == option.Id).Any() ? "selected" : "");

            
            #line default
            #line hidden
WriteLiteral(" value=\"");

            
            #line 27 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                                                                                                                                       Write(option.Id.ToString());

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 27 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                                                                                                                                                              Write(option.Description);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 28 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                    
                }

            
            #line default
            #line hidden
WriteLiteral("            </select>\r\n");

            
            #line 31 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n        <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"https://static.realtair.com/plugins/select2/css/select2.min.css\"");

WriteLiteral(">\r\n        <script");

WriteLiteral(" src=\"https://static.realtair.com/plugins/select2/js/select2.min.js\"");

WriteLiteral("></script>\r\n        <script>\r\n            $(window).resize(function () {\r\n       " +
"         $(\'.select2\').css(\'width\', \"100%\");\r\n            });\r\n\r\n            $(\'" +
"#");

            
            #line 40 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
            Write(hopefullyUniqueId);

            
            #line default
            #line hidden
WriteLiteral("\').select2();\r\n            $(\'#");

            
            #line 41 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
           Write(hopefullyUniqueId);

            
            #line default
            #line hidden
WriteLiteral("\').change(function () {\r\n                $(\'#");

            
            #line 42 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
                Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("\').val(JSON.stringify($(this).val()));\r\n            });\r\n        </script>\r\n    <" +
"/div>\r\n    <input");

WriteAttribute("name", Tuple.Create(" name=\"", 1828), Tuple.Create("\"", 1854)
            
            #line 46 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1835), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 1855), Tuple.Create("\"", 1879)
            
            #line 46 "..\..\Views\Shared\Fields\_MultiSelectOptionsField.cshtml"
, Tuple.Create(Tuple.Create("", 1860), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1860), false)
);

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" value=\"[]\"");

WriteLiteral(" />\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591