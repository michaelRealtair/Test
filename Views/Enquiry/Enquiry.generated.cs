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
    
    #line 1 "..\..\Views\Enquiry\Enquiry.cshtml"
    using Realtair.Framework.Core.Web;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Enquiry\Enquiry.cshtml"
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Enquiry\Enquiry.cshtml"
    using Realtair.Framework.Enquiries.Entities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Enquiry/Enquiry.cshtml")]
    public partial class _Views_Enquiry_Enquiry_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Web.Controllers.EnquiryController.EnquiryViewModel>
    {
        public _Views_Enquiry_Enquiry_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Enquiry\Enquiry.cshtml"
Write(Html.Partial("Menu"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" id=\"page-wrapper\"");

WriteLiteral(" class=\"with-background\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <!-- .chat-row -->\r\n        <div");

WriteLiteral(" class=\"chat-main-box\"");

WriteLiteral(">\r\n            <!-- .chat-left-panel -->\r\n            <div");

WriteLiteral(" class=\"chat-left-aside\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"open-panel\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-angle-right\"");

WriteLiteral("></i></div>\r\n                <div");

WriteLiteral(" class=\"chat-left-inner\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"form-material\"");

WriteLiteral(">\r\n                        <input");

WriteLiteral(" class=\"form-control p-20\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" placeholder=\"Search Contact\"");

WriteLiteral(">\r\n                    </div>\r\n                    <ul");

WriteLiteral(" class=\"chatonline style-none \"");

WriteLiteral(">\r\n");

            
            #line 20 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 20 "..\..\Views\Enquiry\Enquiry.cshtml"
                         foreach (var user in Model.Conversation.Users.Where(u => u != Html.LoggedInUser()))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"https://static.realtair.com/plugins/images/users/varun.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>");

            
            #line 23 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                       Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                                                                    Write(user.RoleType);

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                            </li>\r\n");

            
            #line 25 "..\..\Views\Enquiry\Enquiry.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li");

WriteLiteral(" class=\"p-20\"");

WriteLiteral("></li>\r\n                        <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n                        <li");

WriteLiteral(" class=\"box-label\"");

WriteLiteral(">Other conversations (");

            
            #line 28 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                              Write(Model.Conversations.Where(c => c != Model.Conversation).Count());

            
            #line default
            #line hidden
WriteLiteral(")</li>\r\n");

            
            #line 29 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Enquiry\Enquiry.cshtml"
                         foreach (var user in Model.Conversation.Users.Where(u => u != Html.LoggedInUser()))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"https://static.realtair.com/plugins/images/users/varun.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>");

            
            #line 32 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                       Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 32 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                                                                    Write(user.RoleType);

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                            </li>\r\n");

            
            #line 34 "..\..\Views\Enquiry\Enquiry.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n          " +
"  <!-- .chat-left-panel -->\r\n            <!-- .chat-right-panel -->\r\n           " +
" <div");

WriteLiteral(" class=\"chat-right-aside\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"chat-box\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"messagebox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 43 "..\..\Views\Enquiry\Enquiry.cshtml"
                   Write(Html.Partial("Timeline", Model.Timeline));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"row send-chat-box\"");

WriteLiteral(">\r\n                        <!-- Action Buttons -->\r\n                        <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n");

            
            #line 48 "..\..\Views\Enquiry\Enquiry.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 48 "..\..\Views\Enquiry\Enquiry.cshtml"
                             foreach (var action in Model.Workflow.Extension.Actions().WithAccess(Html.LoggedInUser(), ViewContext.DbContext()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <form");

WriteLiteral(" class=\"inline\"");

WriteAttribute("action", Tuple.Create(" action=\"", 2786), Tuple.Create("\"", 2814)
            
            #line 50 "..\..\Views\Enquiry\Enquiry.cshtml"
, Tuple.Create(Tuple.Create("", 2795), Tuple.Create<System.Object, System.Int32>(action.GetUrl(Url)
            
            #line default
            #line hidden
, 2795), false)
);

WriteAttribute("method", Tuple.Create(" method=\"", 2815), Tuple.Create("\"", 2870)
            
            #line 50 "..\..\Views\Enquiry\Enquiry.cshtml"
           , Tuple.Create(Tuple.Create("", 2824), Tuple.Create<System.Object, System.Int32>(action.Fields.Count() >= 1 ? "GET" : "POST"
            
            #line default
            #line hidden
, 2824), false)
);

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" name=\"ReturnUrl\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2947), Tuple.Create("\"", 2980)
            
            #line 51 "..\..\Views\Enquiry\Enquiry.cshtml"
 , Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(Request.Url.AbsolutePath
            
            #line default
            #line hidden
, 2955), false)
);

WriteLiteral(" />\r\n                                    <button");

WriteLiteral(" class=\"btn btn-sm btn-info btn-outline btn-rounded m-l-10 m-b-10\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                       Write(action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                </form>\r\n");

            
            #line 54 "..\..\Views\Enquiry\Enquiry.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                        <!-- End of Action Button" +
"s -->\r\n                        <!-- --------------------------------------------" +
"------ -->\r\n                        <!--  -->\r\n                        <div");

WriteLiteral(" class=\"col-sm-12 newmessage\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" id=\"file-attachment\"");

WriteLiteral(" class=\"file-attachment\"");

WriteLiteral(" style=\"display: none;\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" id=\"file-attachment-thumbnails\"");

WriteLiteral(" class=\"file-attachment-thumbnails ellipsis\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"preview\"");

WriteLiteral(">\r\n                                        <img data-dz-thumbnail />\r\n           " +
"                             <a data-dz-remove");

WriteLiteral(" class=\"close-file\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-times\"");

WriteLiteral("></i></a>\r\n                                    </span>\r\n                         " +
"       </div>\r\n                            </div>\r\n                            <" +
"div");

WriteLiteral(" id=\"file-attachment-progress\"");

WriteLiteral(" class=\"file-attachment-progress\"");

WriteLiteral(">\r\n                                <h3>Uploading...</h3>\r\n                       " +
"     </div>\r\n                            <textarea");

WriteLiteral(" class=\"form-control chat-box\"");

WriteLiteral(" placeholder=\"Type your message\"");

WriteLiteral(" name=\"messageText\"");

WriteLiteral("></textarea>\r\n                            <div");

WriteLiteral(" class=\"custom-send\"");

WriteLiteral(">\r\n                                <a");

WriteLiteral(" href=\"javacript:void(0)\"");

WriteLiteral(" class=\"cst-icon\"");

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" title=\"Insert Emojis\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-face-smile\"");

WriteLiteral("></i></a>\r\n                                <a");

WriteLiteral(" id=\"attach-file\"");

WriteLiteral(" class=\"cst-icon\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-paperclip\"");

WriteLiteral("></i></a>\r\n                                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" id=\"send-button\"");

WriteLiteral(" class=\"btn btn-danger btn-rounded\"");

WriteLiteral(@">Send</button>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- .chat-right-panel -->
            </div>
            <!-- /.chat-row -->
        </div>
    </div>
</div>
<!-- /#page-wrapper -->

");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/chat.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/dropzone.js\"");

WriteLiteral("></script>\r\n    <script>\r\n        // Setup preview node...\r\n        var previewNo" +
"de = document.querySelector(\"#file-attachment-thumbnails\");\r\n        previewNode" +
".id = \"\";\r\n        var previewTemplate = previewNode.parentNode.innerHTML;\r\n    " +
"    previewNode.parentNode.removeChild(previewNode);\r\n\r\n        // Setup progres" +
"s node...\r\n        var progressNode = document.querySelector(\'#file-attachment-p" +
"rogress\');\r\n        progressNode.id = \'\';\r\n        var progressTemplate = progre" +
"ssNode.parentNode.innerHTML;\r\n        progressNode.parentNode.removeChild(progre" +
"ssNode);\r\n\r\n        // Initialize Dropzone\r\n        var dz = new Dropzone(docume" +
"nt.body, {\r\n            url: \'/\',\r\n            thumbnailWidth: 40,\r\n            " +
"thumbnailHeight: 40,\r\n            parallelUploads: 10,\r\n            previewTempl" +
"ate: previewTemplate,\r\n            autoQueue: false,\r\n            previewsContai" +
"ner: \'#file-attachment\',\r\n            clickable: \'#attach-file\',\r\n            in" +
"it: function () {\r\n                this.on(\'addedfile\', function (file) {\r\n     " +
"               var query = $(\'#file-attachment\');\r\n                    if (!quer" +
"y.is(\':visible\')) {\r\n                        query.show();\r\n                    " +
"}\r\n                });\r\n            }\r\n        });\r\n\r\n        // On-click Handle" +
"rs\r\n        $(\'#send-button\').click(function () {\r\n            sendMessage();\r\n " +
"           dz.removeAllFiles(true);\r\n        });\r\n\r\n    </script>\r\n    <script>\r" +
"\n        var tempSentMessageId = 0;\r\n        var pollTime = 1000 * 10;\r\n\r\n      " +
"  $(function () {\r\n            $(document).scrollTop($(document).height());\r\n\r\n " +
"           $(\'#selectPhotosBtn\').click(function () {\r\n                $(\'#modal-" +
"attachments\').find(\'.picked\').each(function () {\r\n                    var image " +
"= $(this).find(\'img\').attr(\'src\');\r\n                    var storageguid = $(this" +
").find(\'img\').attr(\'storageguid\');\r\n                    $(\'.file-attachment-thum" +
"bnails\').append($(\'<div class=\"existing-preview\" storageguid=\"\' + storageguid + " +
"\'\" style=\"background-image: url(\' + image + \')\"><a class=\"close-file\"><i class=\"" +
"fa fa-times\"></i></a><input type=\"hidden\" name=\"existingAttachments\" value=\"\' + " +
"storageguid + \'\"></div>\'));\r\n                    $(\'.file-attachment, .file-atta" +
"chment-thumbnails\').show();\r\n                    $(this).toggleClass(\"picked\");\r" +
"\n\r\n                    $(\'.existing-preview\').each(function () {\r\n              " +
"          var $this = $(this);\r\n                        $(this).find(\'a.close-fi" +
"le\').click(function () { $this.remove(); });\r\n                    });\r\n         " +
"       });\r\n            });\r\n\r\n            /* Auto popup gallery */\r\n           " +
" var url = window.location.href;\r\n            var hash = url.substring(url.index" +
"Of(\'#\') + 1);\r\n            var queries = hash.split(\"&\");\r\n            for (var " +
"i = 0; i < queries.length; i++) {\r\n                if (queries[i].includes(\"pid\"" +
")) {\r\n                    var pid = queries[i].split(\"=\")[1];\r\n                 " +
"   $(\'#\' + pid).trigger(\'click\');\r\n                }\r\n            }\r\n\r\n         " +
"   var textarea = document.querySelector(\'textarea[name=messageText]\');\r\n       " +
"     textarea.addEventListener(\'keydown\', autosize);\r\n\r\n            function aut" +
"osize() {\r\n                var el = this;\r\n                setTimeout(function (" +
") {\r\n                    el.style.cssText = \'height:auto; padding:0\';\r\n         " +
"           // for box-sizing other than \"content-box\" use:\r\n                    " +
"// el.style.cssText = \'-moz-box-sizing:content-box\';\r\n                    el.sty" +
"le.cssText = \'height:\' + el.scrollHeight + \'px\';\r\n                }, 0);\r\n      " +
"      }\r\n        });\r\n\r\n        function sendMessage() {\r\n            tempSentMe" +
"ssageId++;\r\n\r\n            var messageId = \"sent-\" + tempSentMessageId;\r\n        " +
"    var messageText = $(\'textarea[name=messageText]\').val();\r\n            var at" +
"tachments = $(\".file-attachment .preview\");\r\n            var existingAttachments" +
" = $(\".file-attachment .existing-preview\");\r\n            var files = dz.files.ma" +
"p(function (a, i) {\r\n                return `${a.name}|${$(\'span.preview > img\'," +
" a.previewTemplate).attr(\'src\')}`;\r\n            });\r\n            //var formToSub" +
"mit = $(\"#send-message-form\").serialize();\r\n\r\n            $(\'textarea[name=messa" +
"geText]\').val(\'\');\r\n            $(\'textarea[name=messageText]\').css(\'height\', \'6" +
"0px\');\r\n            $(\'.file-attachment-thumbnails\').empty().hide();\r\n          " +
"  $(\'#file-attachment\').hide();\r\n\r\n            if (attachments.length > 0 || jQu" +
"ery.trim(messageText).length > 0 || existingAttachments.length > 0) {\r\n         " +
"       var message = $(\r\n                    \'<div id=\"\' + messageId + \'\"class=\"" +
"row row-no-gutter answer message-provider sending\">\' +\r\n                        " +
"\'<div class=\"col-md-5 col-md-push-7\">\' +\r\n                        \'<figure>\' +\r\n" +
"                            \'<span class=\"img-circle\">");

            
            #line 200 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                  Write(Html.LoggedInUser().Person.FirstName[0]);

            
            #line default
            #line hidden
            
            #line 200 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                            Write(Html.LoggedInUser().Person.LastName[0]);

            
            #line default
            #line hidden
WriteLiteral("</span>\' +\r\n                        \'</figure>\' +\r\n                        \'<div " +
"class=\"inner-content\">\' +\r\n                            \'<time><span>Now<span></s" +
"pan></span></time>\' +\r\n                            \'<div class=\"clearfix\"></div>" +
"\' +\r\n                            \'<div class=\"panel panel-default\">\' +\r\n        " +
"                        \'<div class=\"panel-body\">\' +\r\n                          " +
"           messageText +\r\n                                    \'</div>\' +\r\n      " +
"                          \'</div>\' +\r\n                            \'</div>\' +\r\n  " +
"                      \'</div>\' +\r\n                        \'<div class=\"col-md-2\"" +
"><div class=\"circle-timeline\"></div></div>\' +\r\n                    \'</div>\');\r\n\r" +
"\n                if (attachments.length > 0 || existingAttachments.length > 0) {" +
"\r\n                    var attachmentHtml = \'<div class=\"file-attachment text-cen" +
"ter\">\';\r\n\r\n                    for (var i = 0; i < attachments.length; i++) {\r\n " +
"                       attachmentHtml += \'<div class=\"spin-icon-box\"><span class" +
"=\"icon icon-Restart spinner\"></span></div>\';\r\n                    }\r\n\r\n         " +
"           for (var i = 0; i < existingAttachments.length; i++) {\r\n             " +
"           attachmentHtml += \'<div class=\"spin-icon-box\"><span class=\"icon icon-" +
"Restart spinner\"></span></div>\';\r\n                    }\r\n\r\n                    a" +
"ttachmentHtml += \"</div>\";\r\n                    message.find(\".panel\").append(\'<" +
"div class=\"panel-footer\"></div>\').find(\".panel-footer\").append(attachmentHtml);\r" +
"\n                }\r\n\r\n                var baseMainHeight = $(document).height();" +
"\r\n                $(\".messagebox\").append(message);\r\n                $(\'html,bod" +
"y\').animate({ scrollTop: $(document).scrollTop() + $(document).height() - baseMa" +
"inHeight }, \"fast\");\r\n\r\n                $.ajax({\r\n                    url: \'/enq" +
"uiry/");

            
            #line 235 "..\..\Views\Enquiry\Enquiry.cshtml"
                              Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 235 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                      Write(Model.Conversation.Id);

            
            #line default
            #line hidden
WriteLiteral(@"/send-message',
                    type: ""POST"",
                    data: {
                        messageText: messageText,
                        attachments: files
                    },
                    enctype: 'multipart/form-data',
                    success: function (insertedId) {
                        doPoll();
                        //$(""#"" + messageId).remove();
                    },
                    error: function (data) {
                        window.location.href = ""/"";
                    }
                });

            }
        }

        function doPoll() {
            $.ajax({
                url: '/enquiry/");

            
            #line 256 "..\..\Views\Enquiry\Enquiry.cshtml"
                          Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 256 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                  Write(Model.Conversation.Id);

            
            #line default
            #line hidden
WriteLiteral(@"/get-updated-timeline?isActive=' + true,
                type: 'GET',
                success: function (data) {

                    var baseMainHeight = $(document).height();

                    $('.messagebox').children().not('.sending').remove();
                    $("".messagebox"").prepend(data);

                    /*$('html,body').animate({
                        scrollTop: $(document).scrollTop() + $(document).height() - baseMainHeight
                    }, ""fast"");*/

                    setTimeout(doPoll, pollTime);
                },
                error: function (data) {
                    window.location.href = ""/"";
                }
            });
        }
    </script>
");

});

WriteLiteral("\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n    <link");

WriteLiteral(" href=\"https://static.realtair.com/css/dropzone/basic.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n    <link");

WriteLiteral(" href=\"https://static.realtair.com/css/dropzone/dropzone.css\"");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(">\r\n");

});

        }
    }
}
#pragma warning restore 1591
