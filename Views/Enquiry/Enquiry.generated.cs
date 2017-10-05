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

WriteLiteral(" class=\"fixed-bar hidden-xs\"");

WriteLiteral(" style=\"position: fixed; top: 110px; height: 15px; width: 100%; background: #f2f2" +
"f3; z-index: 1;\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"page-wrapper\"");

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

WriteLiteral(" class=\"chat-left-header text-truncate\"");

WriteLiteral(">\r\n                        <button");

WriteLiteral(" class=\"chat-left-back btn btn-block btn-default\"");

WriteLiteral(" onclick=\"location.href = \'/\';\"");

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-angle-left\"");

WriteLiteral("></i>\r\n                        </button>\r\n                        <div");

WriteLiteral(" class=\"chat-left-description\"");

WriteLiteral(">\r\n                            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1071), Tuple.Create("\"", 1136)
            
            #line 22 "..\..\Views\Enquiry\Enquiry.cshtml"
, Tuple.Create(Tuple.Create("", 1078), Tuple.Create<System.Object, System.Int32>(Model.Workflow.Extension.GetUrl(Html.LoggedInUser(), Url)
            
            #line default
            #line hidden
, 1078), false)
);

WriteLiteral(">\r\n");

WriteLiteral("                                ");

            
            #line 23 "..\..\Views\Enquiry\Enquiry.cshtml"
                           Write(Model.Workflow.Extension.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            </a>\r\n                        </div>\r\n             " +
"       </div>\r\n                    <ul");

WriteLiteral(" class=\"chatonline style-none \"");

WriteLiteral(">\r\n");

            
            #line 28 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\Enquiry\Enquiry.cshtml"
                         foreach (var user in Model.Conversation.Users.Where(u => u != Html.LoggedInUser()))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><span");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                  Write(user.Person.Initials);

            
            #line default
            #line hidden
WriteLiteral("</span> <span>");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                      Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                    Write(user.Role == null ? "Unknown" : user.Role.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                            </li>\r\n");

            
            #line 33 "..\..\Views\Enquiry\Enquiry.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 35 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Enquiry\Enquiry.cshtml"
                         if (Model.Workflow.Extension is IHasRelatedUsers)
                        {
                            foreach (var user in (Model.Workflow.Extension as IHasRelatedUsers).RelatedUsers(Html.LoggedInUser()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <li>\r\n                                    <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><span");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                      Write(user.Person.Initials);

            
            #line default
            #line hidden
WriteLiteral("</span> <span>");

            
            #line 40 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                          Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 40 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                        Write(user.Role == null ? "Unknown" : user.Role.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                                </li>\r\n");

            
            #line 42 "..\..\Views\Enquiry\Enquiry.cshtml"
                            }
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

            
            #line 52 "..\..\Views\Enquiry\Enquiry.cshtml"
                   Write(Html.Partial("Timeline", Model.Timeline));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"row send-chat-box\"");

WriteLiteral(">\r\n                        <!-- Action Buttons -->\r\n                        <div");

WriteLiteral(" id=\"actionForms\"");

WriteLiteral(" style=\"padding-top: 10px; background: #fff;\"");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n");

            
            #line 57 "..\..\Views\Enquiry\Enquiry.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Enquiry\Enquiry.cshtml"
                             foreach (var action in Model.Workflow.Extension.Actions().WithAccess(Html.LoggedInUser(), ViewContext.DbContext()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <form");

WriteLiteral(" class=\"inline\"");

WriteAttribute("action", Tuple.Create(" action=\"", 3372), Tuple.Create("\"", 3400)
            
            #line 59 "..\..\Views\Enquiry\Enquiry.cshtml"
, Tuple.Create(Tuple.Create("", 3381), Tuple.Create<System.Object, System.Int32>(action.GetUrl(Url)
            
            #line default
            #line hidden
, 3381), false)
);

WriteAttribute("target", Tuple.Create(" target=\"", 3401), Tuple.Create("\"", 3429)
            
            #line 59 "..\..\Views\Enquiry\Enquiry.cshtml"
          , Tuple.Create(Tuple.Create("", 3410), Tuple.Create<System.Object, System.Int32>(action.GetTarget()
            
            #line default
            #line hidden
, 3410), false)
);

WriteAttribute("method", Tuple.Create(" method=\"", 3430), Tuple.Create("\"", 3485)
            
            #line 59 "..\..\Views\Enquiry\Enquiry.cshtml"
                                        , Tuple.Create(Tuple.Create("", 3439), Tuple.Create<System.Object, System.Int32>(action.Fields.Count() >= 1 ? "GET" : "POST"
            
            #line default
            #line hidden
, 3439), false)
);

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" name=\"ReturnUrl\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3562), Tuple.Create("\"", 3595)
            
            #line 60 "..\..\Views\Enquiry\Enquiry.cshtml"
 , Tuple.Create(Tuple.Create("", 3570), Tuple.Create<System.Object, System.Int32>(Request.Url.AbsolutePath
            
            #line default
            #line hidden
, 3570), false)
);

WriteLiteral(" />\r\n                                    <button");

WriteLiteral(" class=\"btn btn-sm btn-info btn-outline btn-rounded m-l-10 m-b-10\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 61 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                       Write(action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                </form>\r\n");

            
            #line 63 "..\..\Views\Enquiry\Enquiry.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n                        <!-- / Action Buttons -->" +
"\r\n                        <!-- -------------------------------------------------" +
"- -->\r\n                        <!--  -->\r\n                        <div");

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

WriteLiteral(" id=\"messageText\"");

WriteLiteral("></textarea>\r\n                            <div");

WriteLiteral(" class=\"custom-send\"");

WriteLiteral(">\r\n                                <a");

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

<div");

WriteLiteral(" class=\"enquiry-footer hidden-xs\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n        <span");

WriteLiteral(" class=\"pull-left\"");

WriteLiteral(">Powered by <a");

WriteLiteral(" href=\"http://realtair.com/\"");

WriteLiteral(">Realtair</a> </span>\r\n        <span");

WriteLiteral(" class=\"pull-right\"");

WriteLiteral(">\r\n            e: <a");

WriteLiteral(" href=\"mailto:support@realtair.com\"");

WriteLiteral(">support");

WriteLiteral("@realtair.com</a> |\r\n            p: <a");

WriteLiteral(" href=\"mailto:support@realtair.com\"");

WriteLiteral(">1300 299 357</a> |\r\n            hours: 8:30 - 5:30\r\n        </span>\r\n    </div>\r" +
"\n</div>\r\n\r\n<!-- /#page-wrapper -->\r\n\r\n<div");

WriteLiteral(" class=\"pswp\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" role=\"dialog\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n    <!-- Background of PhotoSwipe.\r\n         It\'s a separate element as animat" +
"ing opacity is faster than rgba(). -->\r\n    <div");

WriteLiteral(" class=\"pswp__bg\"");

WriteLiteral("></div>\r\n    <!-- Slides wrapper with overflow:hidden. -->\r\n    <div");

WriteLiteral(" class=\"pswp__scroll-wrap\"");

WriteLiteral(">\r\n        <!-- Container that holds slides.\r\n            PhotoSwipe keeps only 3" +
" of them in the DOM to save memory.\r\n            Don\'t modify these 3 pswp__item" +
" elements, data is added later on. -->\r\n        <div");

WriteLiteral(" class=\"pswp__container\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pswp__item\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"pswp__item\"");

WriteLiteral("></div>\r\n            <div");

WriteLiteral(" class=\"pswp__item\"");

WriteLiteral("></div>\r\n        </div>\r\n        <!-- Default (PhotoSwipeUI_Default) interface on" +
" top of sliding area. Can be changed. -->\r\n        <div");

WriteLiteral(" class=\"pswp__ui pswp__ui--hidden\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"pswp__top-bar\"");

WriteLiteral(">\r\n                <!--  Controls are self-explanatory. Order can be changed. -->" +
"\r\n                <div");

WriteLiteral(" class=\"pswp__counter\"");

WriteLiteral("></div>\r\n                <button");

WriteLiteral(" class=\"pswp__button pswp__button--close\"");

WriteLiteral(" title=\"Close (Esc)\"");

WriteLiteral("></button>\r\n                <button");

WriteLiteral(" class=\"pswp__button pswp__button--share\"");

WriteLiteral(" title=\"Share\"");

WriteLiteral("></button>\r\n                <button");

WriteLiteral(" class=\"pswp__button pswp__button--fs\"");

WriteLiteral(" title=\"Toggle fullscreen\"");

WriteLiteral("></button>\r\n                <button");

WriteLiteral(" class=\"pswp__button pswp__button--zoom\"");

WriteLiteral(" title=\"Zoom in/out\"");

WriteLiteral("></button>\r\n                <!-- Preloader demo http://codepen.io/dimsemenov/pen/" +
"yyBWoR -->\r\n                <!-- element will get class pswp__preloader--active " +
"when preloader is running -->\r\n                <div");

WriteLiteral(" class=\"pswp__preloader\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"pswp__preloader__icn\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"pswp__preloader__cut\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"pswp__preloader__donut\"");

WriteLiteral("></div>\r\n                        </div>\r\n                    </div>\r\n            " +
"    </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"pswp__share-modal pswp__share-modal--hidden pswp__single-tap\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"pswp__share-tooltip\"");

WriteLiteral("></div>\r\n            </div>\r\n            <button");

WriteLiteral(" class=\"pswp__button pswp__button--arrow--left\"");

WriteLiteral(" title=\"Previous (arrow left)\"");

WriteLiteral("></button>\r\n            <button");

WriteLiteral(" class=\"pswp__button pswp__button--arrow--right\"");

WriteLiteral(" title=\"Next (arrow right)\"");

WriteLiteral("></button>\r\n            <div");

WriteLiteral(" class=\"pswp__caption\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"pswp__caption__center\"");

WriteLiteral("></div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"https://static.realtair.com/css/photoswipe.css\"");

WriteLiteral(" />\r\n<link");

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" href=\"https://static.realtair.com/plugins/bootstrap-suggest-1.3.6/bootstrap-sugg" +
"est.min.css\"");

WriteLiteral(" />\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/jquery.easing.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/photoswipe.min.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/photoswipe-ui-default.min.js\"");

WriteLiteral("></script>\r\n\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/chat.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/js/dropzone.js\"");

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" src=\"https://static.realtair.com/plugins/bootstrap-suggest-1.3.6/bootstrap-sugge" +
"st.js\"");

WriteLiteral("></script>\r\n\r\n\r\n\r\n    <script>\r\n        $(function () {\r\n            $(\'#messageT" +
"ext\').suggest(\'");

WriteLiteral("@\', {\r\n                data: function (q) {\r\n                    if (q) {\r\n      " +
"                  return $.getJSON(window.location.origin + \"/rest/users\", { que" +
"ry: q, enquiry: ");

            
            #line 172 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                  Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral(@" });
                    }
                },
                map: function (user) {
                    return {
                        value: user[0].ConversationRef,
                        text: '<small>' + user[0].Name + '</small>'
                    }
                }
            });
        });

    </script>

    <script>
        // Variable declaration
        var tempSentMessageId = 0;
        var pollTime = 1000 * 10;
        var messageText = '';
    </script>
    <script>
        var sendMessage = function () {
            tempSentMessageId++;

            var messageId = ""sent-"" + tempSentMessageId;            
            var attachments = $("".file-attachment .preview"");
            var existingAttachments = $("".file-attachment .existing-preview"");

            var files = [];
            for (i = 0; i < dz.files.length; i++)
                files.push(dz.files[i].xhr.response);

            if (files.length > 0 || jQuery.trim(messageText).length > 0 || existingAttachments.length > 0) {

                var baseMainHeight = $(document).height();
                $('html,body').animate({ scrollTop: $(document).scrollTop() + $(document).height() - baseMainHeight }, ""fast"");

                $.ajax({
                    url: '/enquiry/");

            
            #line 210 "..\..\Views\Enquiry\Enquiry.cshtml"
                              Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 210 "..\..\Views\Enquiry\Enquiry.cshtml"
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
                    },
                    error: function (data) {
                        //window.location.href = ""/"";
                    }
                });

            }
        }

        var doPoll = function () {
            $.ajax({
                url: '/enquiry/");

            
            #line 230 "..\..\Views\Enquiry\Enquiry.cshtml"
                          Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 230 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                  Write(Model.Conversation.Id);

            
            #line default
            #line hidden
WriteLiteral("/get-updated-timeline?isActive=\' + true,\r\n                type: \'GET\',\r\n         " +
"       success: function (data) {\r\n\r\n                    var baseMainHeight = $(" +
"document).height();\r\n\r\n                    $(\'.messagebox\').children().not(\'.sen" +
"ding\').remove();\r\n                    $(\".messagebox\").prepend(data);\r\n\r\n       " +
"             //$(\'.chat-list\').slimScroll({\r\n                    //    start: \'b" +
"ottom\'\r\n                    //});\r\n                    //$(\'.slimScrollDiv\').css" +
"(\"height\", \"\");\r\n                    if (navigator.userAgent.match(/iPhone/i)) {" +
"\r\n                        $(\".chat-list > li:last-child\").css(\"padding-bottom\", " +
"\"100px\");\r\n                    }\r\n\r\n                    setTimeout(doPoll, pollT" +
"ime);\r\n                },\r\n                error: function (data) {\r\n           " +
"         window.location.href = \"/\";\r\n                },\r\n                cache:" +
" false\r\n            });\r\n        }\r\n    </script>\r\n    <script>\r\n        // Setu" +
"p preview node...\r\n        var previewNode = document.querySelector(\"#file-attac" +
"hment-thumbnails\");\r\n        previewNode.id = \"\";\r\n        var previewTemplate =" +
" previewNode.parentNode.innerHTML;\r\n        previewNode.parentNode.removeChild(p" +
"reviewNode);\r\n\r\n        // Setup progress node...\r\n        var progressNode = do" +
"cument.querySelector(\'#file-attachment-progress\');\r\n        progressNode.id = \'\'" +
";\r\n        var progressTemplate = progressNode.parentNode.innerHTML;\r\n        pr" +
"ogressNode.parentNode.removeChild(progressNode);\r\n\r\n        // Initialize Dropzo" +
"ne\r\n        Dropzone.autoDiscover = false;\r\n        var dz = new Dropzone(docume" +
"nt.body, {\r\n            url: \'/actions/functions/upload-attachment\',\r\n          " +
"  thumbnailWidth: 40,\r\n            thumbnailHeight: 40,\r\n            parallelUpl" +
"oads: 10,\r\n            previewTemplate: previewTemplate,\r\n            //autoQueu" +
"e: false,\r\n            previewsContainer: \'#file-attachment\',\r\n            click" +
"able: \'#attach-file\',\r\n            autoProcessQueue: false,\r\n            init: f" +
"unction () {\r\n                this.on(\'addedfile\', function (file) {            " +
"         \r\n                    var query = $(\'#file-attachment\');\r\n             " +
"       var ext = file.name.split(\'.\').pop();\r\n                    if (ext == \"pd" +
"f\") {\r\n                        $(file.previewElement).find(\"img\").attr(\"src\", \"h" +
"ttps://static.realtair.com/images/pdf.png\");\r\n                    } else if (ext" +
".indexOf(\"doc\") != -1) {\r\n                        $(file.previewElement).find(\"i" +
"mg\").attr(\"src\", \"https://static.realtair.com/images/doc.png\");\r\n               " +
"     } else if (ext.indexOf(\"xls\") != -1) {\r\n                        $(file.prev" +
"iewElement).find(\"img\").attr(\"src\", \"https://static.realtair.com/images/xls.png\"" +
");\r\n                    } else if (ext.indexOf(\"ppt\") != -1) {\r\n                " +
"        $(file.previewElement).find(\"img\").attr(\"src\", \"https://static.realtair." +
"com/images/ppt.png\");\r\n                    }\r\n                       \r\n         " +
"           query.find(\'img\').attr(\'style\', \'width: 40px; height: 40px;\');\r\n     " +
"               query.show();\r\n                },\r\n                this.on(\"compl" +
"ete\", function (file) {\r\n                    if (this.getUploadingFiles().length" +
" === 0 && this.getQueuedFiles().length === 0) {\r\n                        sendMes" +
"sage();\r\n                        dz.removeAllFiles(true);\r\n                    }" +
"\r\n                }));\r\n            }\r\n        });\r\n\r\n        // On-click Handle" +
"rs\r\n        $(\'#send-button\').click(function () {\r\n\r\n            messageText = $" +
"(\'textarea[name=messageText]\').val();\r\n\r\n            if (dz.files.length == 0 &&" +
" jQuery.trim(messageText).length > 0) {\r\n                sendMessage();\r\n       " +
"     } else if (dz.files.length > 0 || jQuery.trim(messageText).length > 0) {\r\n " +
"               dz.processQueue();\r\n            } else {\r\n                return;" +
"\r\n            }\r\n\r\n            var message = $(\'<li class=\"odd\">\' +\r\n           " +
"                 \'<div class=\"chat-image\"> <span class=\"img-circle\">");

            
            #line 321 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                          Write(Html.LoggedInUser().Person.Initials);

            
            #line default
            #line hidden
WriteLiteral("</span> </div>\' +\r\n                            \'    <div class=\"chat-body\">\' +\r\n " +
"                           \'        <div class=\"chat-text\">\' +\r\n                " +
"            \'            <h4>");

            
            #line 324 "..\..\Views\Enquiry\Enquiry.cshtml"
                                         Write(Html.LoggedInUser().Person.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</h4>\' +\r\n                            \'            <p> \' + $(\'textarea[name=messa" +
"geText]\').val() + \' </p>\' +\r\n                            \'            <b>sending" +
"...</b>\' +\r\n                            \'        </div>\' +\r\n                    " +
"        \'    </div>\' +\r\n                            \'</li>\');\r\n\r\n            $(\'" +
"ul.chat-list\').append(message);\r\n            $(\'textarea[name=messageText]\').val" +
"(\'\');\r\n            $(\'textarea[name=messageText]\').css(\'height\', \'60px\');\r\n     " +
"       $(\'.file-attachment-thumbnails\').empty().hide();\r\n            $(\'#file-at" +
"tachment\').hide();\r\n        });\r\n\r\n    </script>\r\n    <script>\r\n\r\n        //$(\'." +
"chat-list\').slimScroll({\r\n        //    start: \'bottom\'\r\n        //});\r\n\r\n      " +
"  //$(\"#messageText\").focus();\r\n\r\n        //$(\'.slimScrollDiv\').css(\"height\", \"\"" +
");\r\n\r\n        //$(\'.sidebar\').css(\"border-bottom\", \"20px solid #F2F2F3\");\r\n     " +
"   //$(\'#page-wrapper\').css(\"padding-top\",\" 130px\");\r\n        //$(\'body\').css(\"o" +
"verflow-y\", \"hidden\");\r\n\r\n        $(function () {\r\n            /*$(\'#selectPhoto" +
"sBtn\').click(function () {\r\n                $(\'#modal-attachments\').find(\'.picke" +
"d\').each(function () {\r\n                    var image = $(this).find(\'img\').attr" +
"(\'src\');\r\n                    var storageguid = $(this).find(\'img\').attr(\'storag" +
"eguid\');\r\n                    $(\'.file-attachment-thumbnails\').append($(\'<div cl" +
"ass=\"existing-preview\" storageguid=\"\' + storageguid + \'\" style=\"background-image" +
": url(\' + image + \')\"><a class=\"close-file\"><i class=\"fa fa-times\"></i></a><inpu" +
"t type=\"hidden\" name=\"existingAttachments\" value=\"\' + storageguid + \'\"></div>\'))" +
";\r\n                    $(\'.file-attachment, .file-attachment-thumbnails\').show()" +
";\r\n                    $(this).toggleClass(\"picked\");\r\n\r\n                    $(\'" +
".existing-preview\').each(function () {\r\n                        var $this = $(th" +
"is);\r\n                        $(this).find(\'a.close-file\').click(function () { $" +
"this.remove(); });\r\n                    });\r\n                });\r\n            })" +
";*/\r\n\r\n            /* Auto popup gallery */\r\n            var url = window.locati" +
"on.href;\r\n            var hash = url.substring(url.indexOf(\'#\') + 1);\r\n         " +
"   var queries = hash.split(\"&\");\r\n            for (var i = 0; i < queries.lengt" +
"h; i++) {\r\n                if (queries[i].indexOf(\"pid\")) {\r\n                   " +
" var pid = queries[i].split(\"=\")[1];\r\n                    $(\'#\' + pid).trigger(\'" +
"click\');\r\n                }\r\n            }\r\n\r\n            var textarea = documen" +
"t.querySelector(\'textarea[name=messageText]\');\r\n            textarea.addEventLis" +
"tener(\'keydown\', autosize);\r\n\r\n            function autosize() {\r\n              " +
"  var el = this;\r\n                setTimeout(function () {\r\n                    " +
"el.style.cssText = \'height:auto; padding:0\';\r\n                    // for box-siz" +
"ing other than \"content-box\" use:\r\n                    // el.style.cssText = \'-m" +
"oz-box-sizing:content-box\';\r\n                    el.style.cssText = \'height:\' + " +
"el.scrollHeight + \'px\';\r\n                }, 0);\r\n            }\r\n\r\n            $(" +
"window).scrollTop(parseInt($(\'.chat-list\')[0].scrollHeight), \"slow\");\r\n\r\n       " +
" });\r\n\r\n        setTimeout(doPoll, pollTime);\r\n    </script>\r\n");

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
