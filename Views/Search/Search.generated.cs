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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Search/Search.cshtml")]
    public partial class _Views_Search_Search_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Providers.SearchResults>
    {
        public _Views_Search_Search_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Search\Search.cshtml"
Write(Html.Partial("Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"page-wrapper\"");

WriteLiteral(" class=\"\"");

WriteLiteral(">\r\n    <!-- Search Bar  -->\r\n    <div");

WriteLiteral(" class=\"header m-b-15\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"input-group\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"search-box\"");

WriteLiteral(" name=\"query\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 317), Tuple.Create("\"", 350)
, Tuple.Create(Tuple.Create("", 331), Tuple.Create("Find", 331), true)
            
            #line 9 "..\..\Views\Search\Search.cshtml"
  , Tuple.Create(Tuple.Create(" ", 335), Tuple.Create<System.Object, System.Int32>(Model.SetName
            
            #line default
            #line hidden
, 336), false)
);

WriteLiteral(" class=\"form-control\"");

WriteAttribute("value", Tuple.Create(" value=\"", 372), Tuple.Create("\"", 392)
            
            #line 9 "..\..\Views\Search\Search.cshtml"
                                               , Tuple.Create(Tuple.Create("", 380), Tuple.Create<System.Object, System.Int32>(Model.Query
            
            #line default
            #line hidden
, 380), false)
);

WriteLiteral(" autofocus");

WriteLiteral(" onfocus=\"this.value = this.value;\"");

WriteLiteral("/>\r\n                <span");

WriteLiteral(" class=\"input-group-addon\"");

WriteLiteral(">\r\n                    <i");

WriteLiteral(" class=\"fa fa-search\"");

WriteLiteral("></i>\r\n                </span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n " +
"   <!-- End of Search Bar  -->\r\n        \r\n    <!-- Search Results  -->\r\n    <div" +
"");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"panel-wrapper collapse-in\"");

WriteLiteral(">\r\n                        <ul");

WriteLiteral(" id=\"results\"");

WriteLiteral(" class=\"list-group\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 25 "..\..\Views\Search\Search.cshtml"
                       Write(Html.Partial("Results", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </di" +
"v>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- End of Search Resul" +
"ts  -->    \r\n</div>\r\n\r\n");

            
            #line 35 "..\..\Views\Search\Search.cshtml"
Write(Html.Partial("Footer"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral(@"
    <script>
        var timeoutID = null;

        $('#search-box').on('input', function () {
            console.log('did debounce')
            clearTimeout(timeoutID);
            timeoutID = setTimeout(function () { search(); }, 300);
        });

        function search() {
            $.post(""");

            
            #line 48 "..\..\Views\Search\Search.cshtml"
               Write(Request.Url.AbsolutePath);

            
            #line default
            #line hidden
WriteLiteral("?query=\" + $(\"#search-box\").val(), function (data) {\r\n                $(\"#results" +
"\").html(data);\r\n            });\r\n        }\r\n    </script>\r\n");

});

WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral(@"
    <style>
        #page-wrapper .header {
            padding: 10px 0;
            margin-top: -15px;
            background: url(""https://static.realtair.com/plugins/images/header_bg.jpg"");
            background-position: center left;
        }

            #page-wrapper .header .input-group {
                margin-bottom: 10px;
            }

                #page-wrapper .header .input-group input {
                    padding: 25px;
                }

                    #page-wrapper .header .input-group input:focus {
                        border-color: #e4e7ea;
                    }


        ");

WriteLiteral("@media (min-width: 768px) {\r\n            #page-wrapper .header {\r\n               " +
" margin-top: -26px;\r\n                padding-top: 40px;\r\n                padding" +
"-bottom: 40px;\r\n            }\r\n        }\r\n\r\n        /*.sidebar {\r\n            ba" +
"ckground: #5f5e5c;\r\n        }\r\n\r\n        #side-menu li a {\r\n            color: #" +
"fff;\r\n        }*/\r\n\r\n        a.action {\r\n            font-size: 18px;\r\n         " +
"   color: #fff;\r\n            font-weight: 400;\r\n        }\r\n\r\n            a.actio" +
"n:hover {\r\n                color: #ff4637;\r\n                transition: color ea" +
"se-in 0.2s;\r\n            }\r\n\r\n            a.action i {\r\n                font-siz" +
"e: 25px;\r\n                display: block;\r\n                margin-bottom: 15px;\r" +
"\n            }\r\n\r\n        #page-wrapper li.list-group-item {\r\n            paddin" +
"g: 15px 20px;\r\n            border-left: none;\r\n            border-right: none;\r\n" +
"        }\r\n\r\n            #page-wrapper li.list-group-item a {\r\n                c" +
"olor: #313131;\r\n            }\r\n\r\n                #page-wrapper li.list-group-ite" +
"m i, #page-wrapper li.list-group-item b, #page-wrapper li.list-group-item a.btn " +
"{\r\n                    overflow: hidden;\r\n                    white-space: nowra" +
"p;\r\n                    text-overflow: ellipsis;\r\n                    display: b" +
"lock;\r\n                    max-width: 100%;\r\n                    font-style: nor" +
"mal;\r\n                }\r\n\r\n\r\n            #page-wrapper li.list-group-item .empty" +
"-filler * {\r\n                display: inline-block;\r\n            }\r\n    </style>" +
"\r\n");

});

        }
    }
}
#pragma warning restore 1591
