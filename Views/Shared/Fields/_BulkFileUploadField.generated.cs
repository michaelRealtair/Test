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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_BulkFileUploadField.cshtml")]
    public partial class _Views_Shared_Fields__BulkFileUploadField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__BulkFileUploadField_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-md-3 col-sm-4\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">");

            
            #line 5 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"col-md-9 col-sm-8\"");

WriteLiteral(">\r\n        <div");

WriteAttribute("id", Tuple.Create(" id=\"", 233), Tuple.Create("\"", 264)
            
            #line 9 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
, Tuple.Create(Tuple.Create("", 238), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 238), false)
, Tuple.Create(Tuple.Create("", 257), Tuple.Create("_upload", 257), true)
);

WriteLiteral(" class=\"dropzone file-uploader\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"dz-default dz-clickable dz-message\"");

WriteLiteral(">\r\n                <span>Drop files here to upload</span>\r\n            </div>\r\n  " +
"      </div>\r\n        <input");

WriteAttribute("name", Tuple.Create(" name=\"", 467), Tuple.Create("\"", 493)
            
            #line 14 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
, Tuple.Create(Tuple.Create("", 474), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 474), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 494), Tuple.Create("\"", 518)
            
            #line 14 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
, Tuple.Create(Tuple.Create("", 499), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 499), false)
);

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" value=\"[]\"");

WriteLiteral(" />\r\n    </div>\r\n</div>\r\n\r\n");

            
            #line 18 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
 using (Html.Delayed())
{      

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" href=\"http://static.realtair.com/plugins/bower_components/dropzone-master/dist/d" +
"ropzone.css\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <script");

WriteLiteral(" src=\"http://static.realtair.com/plugins/bower_components/dropzone-master/dist/dr" +
"opzone.js\"");

WriteLiteral("></script>\r\n");

WriteLiteral("    <script>\r\n        Dropzone.autoDiscover = false;\r\n\r\n        var d = $(\"#");

            
            #line 25 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral(@"_upload"").dropzone({
            url: ""/actions/functions/upload-attachment"",
            addRemoveLinks: true,
            success: function (file, response) {
                var imageId = parseInt(response);
                var list = JSON.parse($('#");

            
            #line 30 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                                      Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("\').val());\r\n                list.push(imageId);\r\n                $(\'#");

            
            #line 32 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral(@"').val(JSON.stringify(list));

                file.previewElement.setAttribute('data-documentid', imageId);
                file.previewElement.classList.add(""dz-success"");
            },
            error: function (file, response) {
                file.previewElement.classList.add(""dz-error"");
            },
            removedfile: function (file) {
                var list = JSON.parse($('#");

            
            #line 41 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                                      Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("\').val());\r\n                var imageId = parseInt(file.previewElement.getAttribu" +
"te(\"data-documentid\"));\r\n                list = list.splice(list.indexOf(imageId" +
") - 1, 1);\r\n                $(\'#");

            
            #line 44 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
                Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral(@"').val(JSON.stringify(list));
                file.previewElement.parentElement.removeChild(file.previewElement);
                return true;
            }
        });

        d.on(""removedFile"", function (file) {
            alert(""aaa!"");
        });
    </script>
");

            
            #line 54 "..\..\Views\Shared\Fields\_BulkFileUploadField.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
