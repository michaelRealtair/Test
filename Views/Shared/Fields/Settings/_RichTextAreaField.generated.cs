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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/Settings/_RichTextAreaField.cshtml")]
    public partial class _Views_Shared_Fields_Settings__RichTextAreaField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields_Settings__RichTextAreaField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
 if (Model.HasError)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group has-error\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 7 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n            <textarea");

WriteAttribute("name", Tuple.Create(" name=\"", 297), Tuple.Create("\"", 321)
            
            #line 11 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
, Tuple.Create(Tuple.Create("", 304), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 304), false)
);

WriteLiteral(" placeholder=\"...\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">");

            
            #line 11 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                                                                                 Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("</textarea>\r\n            <span");

WriteLiteral(" class=\"help-block\"");

WriteLiteral(">");

            
            #line 12 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                                Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n");

            
            #line 15 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                                    Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        </div>\r\n\r\n        <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n            <textarea");

WriteLiteral(" class=\"form-control input-lg rich-text-area\"");

WriteLiteral(" cols=\"20\"");

WriteAttribute("id", Tuple.Create(" id=\"", 761), Tuple.Create("\"", 783)
            
            #line 24 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
  , Tuple.Create(Tuple.Create("", 766), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 766), false)
);

WriteAttribute("name", Tuple.Create(" name=\"", 784), Tuple.Create("\"", 808)
            
            #line 24 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                           , Tuple.Create(Tuple.Create("", 791), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 791), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 809), Tuple.Create("\"", 835)
            
            #line 24 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
                                                           , Tuple.Create(Tuple.Create("", 823), Tuple.Create<System.Object, System.Int32>(Model.Label
            
            #line default
            #line hidden
, 823), false)
);

WriteLiteral(" rows=\"20\"");

WriteLiteral(" style=\"resize: none; width: 400px; display: none;\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 25 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
           Write(Model.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </textarea>\r\n        </div>\r\n    </div>\r\n");

            
            #line 29 "..\..\Views\Shared\Fields\Settings\_RichTextAreaField.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"https://static.realtair.com/summernote/summernote.css\"");

WriteLiteral(" />\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(" src=\"https://static.realtair.com/summernote/summernote.min.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(document).ready(function () {\r\n        $(\'.rich-text-area\').summernote({" +
"\r\n            height: 480,\r\n            focus: true\r\n        });\r\n    });\r\n</scr" +
"ipt>\r\n");

        }
    }
}
#pragma warning restore 1591
