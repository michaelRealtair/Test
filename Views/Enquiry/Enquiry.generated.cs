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
"f3; z-index: 1000;\"");

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

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 22 "..\..\Views\Enquiry\Enquiry.cshtml"
                       Write(Model.Workflow.Extension.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                   " +
" <ul");

WriteLiteral(" class=\"chatonline style-none \"");

WriteLiteral(">\r\n");

            
            #line 26 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 26 "..\..\Views\Enquiry\Enquiry.cshtml"
                         foreach (var user in Model.Conversation.Users.Where(u => u != Html.LoggedInUser()))
                        {                            

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><span");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                  Write(user.Person.Initials);

            
            #line default
            #line hidden
WriteLiteral("</span> <span>");

            
            #line 29 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                      Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 29 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                    Write(user.Role == null ? "Unknown" : user.Role.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>                                \r\n                            " +
"</li>\r\n");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 40 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 45 "..\..\Views\Enquiry\Enquiry.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Enquiry\Enquiry.cshtml"
                             foreach (var action in Model.Workflow.Extension.Actions().WithAccess(Html.LoggedInUser(), ViewContext.DbContext()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <form");

WriteLiteral(" class=\"inline\"");

WriteAttribute("action", Tuple.Create(" action=\"", 2625), Tuple.Create("\"", 2653)
            
            #line 47 "..\..\Views\Enquiry\Enquiry.cshtml"
, Tuple.Create(Tuple.Create("", 2634), Tuple.Create<System.Object, System.Int32>(action.GetUrl(Url)
            
            #line default
            #line hidden
, 2634), false)
);

WriteAttribute("method", Tuple.Create(" method=\"", 2654), Tuple.Create("\"", 2709)
            
            #line 47 "..\..\Views\Enquiry\Enquiry.cshtml"
           , Tuple.Create(Tuple.Create("", 2663), Tuple.Create<System.Object, System.Int32>(action.Fields.Count() >= 1 ? "GET" : "POST"
            
            #line default
            #line hidden
, 2663), false)
);

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" name=\"ReturnUrl\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2786), Tuple.Create("\"", 2819)
            
            #line 48 "..\..\Views\Enquiry\Enquiry.cshtml"
 , Tuple.Create(Tuple.Create("", 2794), Tuple.Create<System.Object, System.Int32>(Request.Url.AbsolutePath
            
            #line default
            #line hidden
, 2794), false)
);

WriteLiteral(" />\r\n                                    <button");

WriteLiteral(" class=\"btn btn-sm btn-info btn-outline btn-rounded m-l-10 m-b-10\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 49 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                       Write(action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                </form>\r\n");

            
            #line 51 "..\..\Views\Enquiry\Enquiry.cshtml"
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

WriteLiteral(" id=\"messageText\"");

WriteLiteral("></textarea>\r\n                            <div");

WriteLiteral(" class=\"custom-send\"");

WriteLiteral(">                                \r\n                                <a");

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

<div");

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

WriteLiteral("></script> \r\n\r\n    <script>\r\n        // Setup preview node...\r\n        var previe" +
"wNode = document.querySelector(\"#file-attachment-thumbnails\");\r\n        previewN" +
"ode.id = \"\";\r\n        var previewTemplate = previewNode.parentNode.innerHTML;\r\n " +
"       previewNode.parentNode.removeChild(previewNode);\r\n\r\n        // Setup prog" +
"ress node...\r\n        var progressNode = document.querySelector(\'#file-attachmen" +
"t-progress\');\r\n        progressNode.id = \'\';\r\n        var progressTemplate = pro" +
"gressNode.parentNode.innerHTML;\r\n        progressNode.parentNode.removeChild(pro" +
"gressNode);\r\n\r\n        // Initialize Dropzone\r\n        var dz = new Dropzone(doc" +
"ument.body, {\r\n            url: \'/\',\r\n            thumbnailWidth: null,\r\n       " +
"     thumbnailHeight: null,\r\n            parallelUploads: 10,\r\n            previ" +
"ewTemplate: previewTemplate,\r\n            autoQueue: false,\r\n            preview" +
"sContainer: \'#file-attachment\',\r\n            clickable: \'#attach-file\',\r\n       " +
"     init: function () {\r\n                this.on(\'addedfile\', function (file) {" +
"\r\n                    var query = $(\'#file-attachment\');\r\n                    if" +
" (!query.is(\':visible\')) {\r\n                        query.find(\'img\').attr(\'styl" +
"e\',\'height: 40px; width: 40px;\');\r\n                        query.show();\r\n      " +
"              }\r\n                });\r\n            }\r\n        });\r\n\r\n        // O" +
"n-click Handlers\r\n        $(\'#send-button\').click(function () {\r\n            sen" +
"dMessage();\r\n            dz.removeAllFiles(true);\r\n        });\r\n\r\n    </script>\r" +
"\n    <script>\r\n        var tempSentMessageId = 0;\r\n        var pollTime = 1000 *" +
" 10;       \r\n        \r\n        //$(\'.chat-list\').slimScroll({            \r\n     " +
"   //    start: \'bottom\'\r\n        //});\r\n        \r\n        //$(\"#messageText\").f" +
"ocus();                \r\n        \r\n        //$(\'.slimScrollDiv\').css(\"height\", \"" +
"\");    \r\n        \r\n        //$(\'.sidebar\').css(\"border-bottom\", \"20px solid #F2F" +
"2F3\");\r\n        //$(\'#page-wrapper\').css(\"padding-top\",\" 130px\");\r\n        //$(\'" +
"body\').css(\"overflow-y\", \"hidden\");\r\n\r\n        $(function () {\r\n            $(\'#" +
"selectPhotosBtn\').click(function () {\r\n                $(\'#modal-attachments\').f" +
"ind(\'.picked\').each(function () {\r\n                    var image = $(this).find(" +
"\'img\').attr(\'src\');\r\n                    var storageguid = $(this).find(\'img\').a" +
"ttr(\'storageguid\');\r\n                    $(\'.file-attachment-thumbnails\').append" +
"($(\'<div class=\"existing-preview\" storageguid=\"\' + storageguid + \'\" style=\"backg" +
"round-image: url(\' + image + \')\"><a class=\"close-file\"><i class=\"fa fa-times\"></" +
"i></a><input type=\"hidden\" name=\"existingAttachments\" value=\"\' + storageguid + \'" +
"\"></div>\'));\r\n                    $(\'.file-attachment, .file-attachment-thumbnai" +
"ls\').show();\r\n                    $(this).toggleClass(\"picked\");\r\n\r\n            " +
"        $(\'.existing-preview\').each(function () {\r\n                        var $" +
"this = $(this);\r\n                        $(this).find(\'a.close-file\').click(func" +
"tion () { $this.remove(); });\r\n                    });\r\n                });\r\n   " +
"         });\r\n\r\n            /* Auto popup gallery */\r\n            var url = wind" +
"ow.location.href;\r\n            var hash = url.substring(url.indexOf(\'#\') + 1);\r\n" +
"            var queries = hash.split(\"&\");\r\n            for (var i = 0; i < quer" +
"ies.length; i++) {\r\n                if (queries[i].includes(\"pid\")) {\r\n         " +
"           var pid = queries[i].split(\"=\")[1];\r\n                    $(\'#\' + pid)" +
".trigger(\'click\');\r\n                }\r\n            }\r\n\r\n            var textarea" +
" = document.querySelector(\'textarea[name=messageText]\');\r\n            textarea.a" +
"ddEventListener(\'keydown\', autosize);\r\n\r\n            function autosize() {\r\n    " +
"            var el = this;\r\n                setTimeout(function () {\r\n          " +
"          el.style.cssText = \'height:auto; padding:0\';\r\n                    // f" +
"or box-sizing other than \"content-box\" use:\r\n                    // el.style.css" +
"Text = \'-moz-box-sizing:content-box\';\r\n                    el.style.cssText = \'h" +
"eight:\' + el.scrollHeight + \'px\';\r\n                }, 0);\r\n            }\r\n\r\n    " +
"        $(window).scrollTop(parseInt($(\'.chat-list\')[0].scrollHeight), \"slow\"); " +
"           \r\n        });\r\n\r\n        function sendMessage() {\r\n            tempSe" +
"ntMessageId++;\r\n\r\n            var messageId = \"sent-\" + tempSentMessageId;\r\n    " +
"        var messageText = $(\'textarea[name=messageText]\').val();\r\n            va" +
"r attachments = $(\".file-attachment .preview\");\r\n            var existingAttachm" +
"ents = $(\".file-attachment .existing-preview\");\r\n            var files = dz.file" +
"s.map(function (a, i) {\r\n                return `${a.name}|${$(\'span.preview > i" +
"mg\', a.previewTemplate).attr(\'src\')}`;\r\n            });\r\n\r\n            var messa" +
"ge = $(\'<li class=\"odd\">\' +\r\n                            \'<div class=\"chat-image" +
"\"> <span class=\"img-circle\">");

            
            #line 251 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                          Write(Html.LoggedInUser().Person.Initials);

            
            #line default
            #line hidden
WriteLiteral("</span> </div>\' +\r\n                            \'    <div class=\"chat-body\">\' +\r\n " +
"                           \'        <div class=\"chat-text\">\' +\r\n                " +
"            \'            <h4>");

            
            #line 254 "..\..\Views\Enquiry\Enquiry.cshtml"
                                         Write(Html.LoggedInUser().Person.FirstName[0]);

            
            #line default
            #line hidden
            
            #line 254 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                   Write(Html.LoggedInUser().Person.LastName[0]);

            
            #line default
            #line hidden
WriteLiteral(@"</h4>' +
                            '            <p> ' + messageText + ' </p>' +                            
                            '        </div>' +
                            '    </div>' +
                            '</li>');
            //var formToSubmit = $(""#send-message-form"").serialize();

            $('ul.chat-list').append(message);            

            $('textarea[name=messageText]').val('');
            $('textarea[name=messageText]').css('height', '60px');
            $('.file-attachment-thumbnails').empty().hide();
            $('#file-attachment').hide();

            if (attachments.length > 0 || jQuery.trim(messageText).length > 0 || existingAttachments.length > 0) {

                var baseMainHeight = $(document).height();
                $('html,body').animate({ scrollTop: $(document).scrollTop() + $(document).height() - baseMainHeight }, ""fast"");

                $.ajax({
                    url: '/enquiry/");

            
            #line 274 "..\..\Views\Enquiry\Enquiry.cshtml"
                              Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 274 "..\..\Views\Enquiry\Enquiry.cshtml"
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
                        window.location.href = ""/"";
                    }
                });

            }
        }

        function doPoll() {
            $.ajax({
                url: '/enquiry/");

            
            #line 294 "..\..\Views\Enquiry\Enquiry.cshtml"
                          Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 294 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                  Write(Model.Conversation.Id);

            
            #line default
            #line hidden
WriteLiteral(@"/get-updated-timeline?isActive=' + true,
                type: 'GET',
                success: function (data) {

                    var baseMainHeight = $(document).height();

                    $('.messagebox').children().not('.sending').remove();
                    $("".messagebox"").prepend(data);
                    
                    //$('.chat-list').slimScroll({
                    //    start: 'bottom'
                    //});
                    //$('.slimScrollDiv').css(""height"", """");
                    if (navigator.userAgent.match(/iPhone/i)) {
                        $("".chat-list > li:last-child"").css(""padding-bottom"", ""100px"");
                    }

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
