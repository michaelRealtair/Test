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
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 5 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 19 "..\..\Views\Enquiry\Enquiry.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 19 "..\..\Views\Enquiry\Enquiry.cshtml"
                         foreach (var user in Model.Conversation.Users.Where(u => u != Html.LoggedInUser()))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"http://static.realtair.com/plugins/images/users/varun.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>");

            
            #line 22 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                      Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 22 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                                                                   Write(user.RoleType);

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                            </li>\r\n");

            
            #line 24 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 27 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                              Write(Model.Conversations.Where(c => c != Model.Conversation).Count());

            
            #line default
            #line hidden
WriteLiteral(")</li>\r\n");

            
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

WriteLiteral("><img");

WriteLiteral(" src=\"http://static.realtair.com/plugins/images/users/varun.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                      Write(user.Person.Name);

            
            #line default
            #line hidden
WriteLiteral("<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                                                                                                                                                                                   Write(user.RoleType);

            
            #line default
            #line hidden
WriteLiteral("</small></span></a>\r\n                            </li>\r\n");

            
            #line 33 "..\..\Views\Enquiry\Enquiry.cshtml"
                        }  

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n          " +
"  <!-- .chat-left-panel -->\r\n            <!-- .chat-right-panel -->\r\n           " +
" <div");

WriteLiteral(" class=\"chat-right-aside\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"chat-main-header hidden-xs\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"p-20 b-b\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" class=\"box-title\"");

WriteLiteral(">Chat Message</h3>\r\n                    </div>\r\n                </div>\r\n         " +
"       <div");

WriteLiteral(" class=\"chat-box\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"messagebox\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 47 "..\..\Views\Enquiry\Enquiry.cshtml"
                   Write(Html.Partial("Timeline", Model.Timeline));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                    <form");

WriteLiteral(" class=\"form-inline\"");

WriteLiteral(" id=\"send-message-form\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"row send-chat-box\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"col-sm-12\"");

WriteLiteral(">\r\n                                <textarea");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" placeholder=\"Type your message\"");

WriteLiteral("  name=\"messageText\"");

WriteLiteral("></textarea>\r\n                                <div");

WriteLiteral(" class=\"custom-send\"");

WriteLiteral(">\r\n                                    <a");

WriteLiteral(" href=\"javacript:void(0)\"");

WriteLiteral(" class=\"cst-icon\"");

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" title=\"Insert Emojis\"");

WriteLiteral("><i");

WriteLiteral(" class=\"ti-face-smile\"");

WriteLiteral("></i></a> <a");

WriteLiteral(" href=\"javacript:void(0)\"");

WriteLiteral(" class=\"cst-icon\"");

WriteLiteral(" data-toggle=\"tooltip\"");

WriteLiteral(" title=\"File Attachment\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-paperclip\"");

WriteLiteral("></i></a>\r\n                                    <button");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"btn btn-danger btn-rounded\"");

WriteLiteral(@">Send</button>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
            <!-- .chat-right-panel -->
        </div>
        <!-- /.chat-row -->
        <!-- ============================================================== -->
        <!-- Right sidebar -->
        <!-- ============================================================== -->
        <!-- .right-sidebar -->
        <div");

WriteLiteral(" class=\"right-sidebar\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"slimscrollright\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"rpanel-title\"");

WriteLiteral("> Service Panel <span><i");

WriteLiteral(" class=\"ti-close right-side-toggle\"");

WriteLiteral("></i></span> </div>\r\n                <div");

WriteLiteral(" class=\"r-panel-body\"");

WriteLiteral(">\r\n                    <ul");

WriteLiteral(" id=\"themecolors\"");

WriteLiteral(" class=\"m-t-20\"");

WriteLiteral(">\r\n                        <li><b>With Light sidebar</b></li>\r\n                  " +
"      <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"default\"");

WriteLiteral(" class=\"default-theme\"");

WriteLiteral(">1</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"green\"");

WriteLiteral(" class=\"green-theme\"");

WriteLiteral(">2</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"gray\"");

WriteLiteral(" class=\"yellow-theme\"");

WriteLiteral(">3</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"blue\"");

WriteLiteral(" class=\"blue-theme\"");

WriteLiteral(">4</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"purple\"");

WriteLiteral(" class=\"purple-theme\"");

WriteLiteral(">5</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"megna\"");

WriteLiteral(" class=\"megna-theme\"");

WriteLiteral(">6</a></li>\r\n                        <li><b>With Dark sidebar</b></li>\r\n         " +
"               <br />\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"default-dark\"");

WriteLiteral(" class=\"default-dark-theme\"");

WriteLiteral(">7</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"green-dark\"");

WriteLiteral(" class=\"green-dark-theme\"");

WriteLiteral(">8</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"gray-dark\"");

WriteLiteral(" class=\"yellow-dark-theme\"");

WriteLiteral(">9</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"blue-dark\"");

WriteLiteral(" class=\"blue-dark-theme\"");

WriteLiteral(">10</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"purple-dark\"");

WriteLiteral(" class=\"purple-dark-theme\"");

WriteLiteral(">11</a></li>\r\n                        <li><a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral(" data-theme=\"megna-dark\"");

WriteLiteral(" class=\"megna-dark-theme working\"");

WriteLiteral(">12</a></li>\r\n                    </ul>\r\n                    <ul");

WriteLiteral(" class=\"m-t-20 all-demos\"");

WriteLiteral(">\r\n                        <li><b>Choose other demos</b></li>\r\n                  " +
"  </ul>\r\n                    <ul");

WriteLiteral(" class=\"m-t-20 chatonline\"");

WriteLiteral(">\r\n                        <li><b>Chat option</b></li>\r\n                        <" +
"li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/varun.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Varun Dhavan <small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">online</small></span></a>\r\n                        </li>\r\n                      " +
"  <li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/genu.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Genelia Deshmukh <small");

WriteLiteral(" class=\"text-warning\"");

WriteLiteral(">Away</small></span></a>\r\n                        </li>\r\n                        " +
"<li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/ritesh.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Ritesh Deshmukh <small");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral(">Busy</small></span></a>\r\n                        </li>\r\n                        " +
"<li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/arijit.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Arijit Sinh <small");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">Offline</small></span></a>\r\n                        </li>\r\n                     " +
"   <li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/govinda.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Govinda Star <small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">online</small></span></a>\r\n                        </li>\r\n                      " +
"  <li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/hritik.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>John Abraham<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">online</small></span></a>\r\n                        </li>\r\n                      " +
"  <li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/john.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Hritik Roshan<small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(">online</small></span></a>\r\n                        </li>\r\n                      " +
"  <li>\r\n                            <a");

WriteLiteral(" href=\"javascript:void(0)\"");

WriteLiteral("><img");

WriteLiteral(" src=\"../plugins/images/users/pawandeep.jpg\"");

WriteLiteral(" alt=\"user-img\"");

WriteLiteral(" class=\"img-circle\"");

WriteLiteral("> <span>Pwandeep rajan <small");

WriteLiteral(" class=\"text-success\"");

WriteLiteral(@">online</small></span></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- ============================================================== -->
        <!-- End Right sidebar -->
        <!-- ============================================================== -->
    </div>
    <!-- /.container-fluid -->
    <footer");

WriteLiteral(" class=\"footer text-center hidden-xs\"");

WriteLiteral("> Powered by Realtair</footer>\r\n</div>\r\n<!-- /#page-wrapper -->\r\n\r\n");

DefineSection("Styles", () => {

WriteLiteral("\r\n    <script");

WriteLiteral(" src=\"http://static.realtair.com/js/chat.js\"");

WriteLiteral("></script>\r\n<script>\r\n        var tempSentMessageId = 0;\r\n        var pollTime = " +
"1000 * 10;\r\n\r\n        $(function () {\r\n            $(document).scrollTop($(docum" +
"ent).height());\r\n            setTimeout(doPoll, pollTime);\r\n\r\n            $(\'#se" +
"nd-message-form\').submit(function (e) {\r\n                e.preventDefault();\r\n  " +
"              sendMessage();\r\n            });\r\n\r\n            $(\'.icon-PaperClip\'" +
").parent().click(function () {\r\n                $(\'#attachments\').trigger(\'click" +
"\');\r\n                $(\'.file-attachment\').show();\r\n            });\r\n\r\n         " +
"   //$(\'.file-attachment\').hide();\r\n\r\n            $(\'.close-file\').click(functio" +
"n () {\r\n                if ($(\"#send-message-form .file-attachment .preview\").le" +
"ngth == 0) $(\'.file-attachment\').hide();\r\n            });\r\n\r\n            $(\'#sel" +
"ectPhotosBtn\').click(function () {\r\n                $(\'#modal-attachments\').find" +
"(\'.picked\').each(function () {\r\n                    var image = $(this).find(\'im" +
"g\').attr(\'src\');\r\n                    var storageguid = $(this).find(\'img\').attr" +
"(\'storageguid\');\r\n                    $(\'.file-attachment-thumbnails\').append($(" +
"\'<div class=\"existing-preview\" storageguid=\"\' + storageguid + \'\" style=\"backgrou" +
"nd-image: url(\' + image + \')\"><a class=\"close-file\"><i class=\"fa fa-times\"></i><" +
"/a><input type=\"hidden\" name=\"existingAttachments\" value=\"\' + storageguid + \'\"><" +
"/div>\'));\r\n                    $(\'.file-attachment, .file-attachment-thumbnails\'" +
").show();\r\n                    $(this).toggleClass(\"picked\");\r\n\r\n               " +
"     $(\'.existing-preview\').each(function () {\r\n                        var $thi" +
"s = $(this);\r\n                        $(this).find(\'a.close-file\').click(functio" +
"n () { $this.remove(); });\r\n                    });\r\n                });\r\n      " +
"      });\r\n\r\n            /* Auto popup gallery */\r\n            var url = window." +
"location.href;\r\n            var hash = url.substring(url.indexOf(\'#\') + 1);\r\n   " +
"         var queries = hash.split(\"&\");\r\n            for (var i = 0; i < queries" +
".length; i++) {\r\n                if (queries[i].includes(\"pid\")) {\r\n            " +
"        var pid = queries[i].split(\"=\")[1];\r\n                    $(\'#\' + pid).tr" +
"igger(\'click\');\r\n                }\r\n            }\r\n\r\n            var textarea = " +
"document.querySelector(\'textarea[name=messageText]\');\r\n            textarea.addE" +
"ventListener(\'keydown\', autosize);\r\n\r\n            function autosize() {\r\n       " +
"         var el = this;\r\n                setTimeout(function () {\r\n             " +
"       el.style.cssText = \'height:auto; padding:0\';\r\n                    // for " +
"box-sizing other than \"content-box\" use:\r\n                    // el.style.cssTex" +
"t = \'-moz-box-sizing:content-box\';\r\n                    el.style.cssText = \'heig" +
"ht:\' + el.scrollHeight + \'px\';\r\n                }, 0);\r\n            }\r\n        }" +
");\r\n\r\n        function sendMessage() {\r\n            tempSentMessageId++;\r\n\r\n    " +
"        var messageId = \"sent-\" + tempSentMessageId;\r\n            var messageTex" +
"t = $(\'#send-message-form textarea[name=messageText]\').val();\r\n            var a" +
"ttachments = $(\"#send-message-form .file-attachment .preview\");\r\n            var" +
" existingAttachments = $(\"#send-message-form .file-attachment .existing-preview\"" +
");\r\n            var formToSubmit = $(\"#send-message-form\").serialize();\r\n\r\n     " +
"       $(\'textarea[name=messageText]\').val(\'\');\r\n            $(\'textarea[name=me" +
"ssageText]\').css(\'height\', \'60px\');\r\n            $(\'.file-attachment-thumbnails\'" +
").empty().hide();\r\n            $(\'#file-attachment\').hide();\r\n\r\n            if (" +
"attachments.length > 0 || jQuery.trim(messageText).length > 0 || existingAttachm" +
"ents.length > 0) {\r\n                var message = $(\r\n                    \'<div " +
"id=\"\' + messageId + \'\"class=\"row row-no-gutter answer message-provider sending\">" +
"\' +\r\n                        \'<div class=\"col-md-5 col-md-push-7\">\' +\r\n         " +
"               \'<figure>\' +\r\n                            \'<span class=\"img-circl" +
"e\">");

            
            #line 217 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                  Write(Html.LoggedInUser().Person.FirstName[0]);

            
            #line default
            #line hidden
            
            #line 217 "..\..\Views\Enquiry\Enquiry.cshtml"
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

            
            #line 252 "..\..\Views\Enquiry\Enquiry.cshtml"
                              Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 252 "..\..\Views\Enquiry\Enquiry.cshtml"
                                                      Write(Model.Conversation.Id);

            
            #line default
            #line hidden
WriteLiteral(@"/send-message',
                    type: ""POST"",
                    data: formToSubmit,
                    enctype: 'multipart/form-data',
                    success: function (insertedId) {
                        doPoll();
                        $(""#"" + messageId).remove();
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

            
            #line 270 "..\..\Views\Enquiry\Enquiry.cshtml"
                          Write(Model.Workflow.Id);

            
            #line default
            #line hidden
WriteLiteral("/chat/");

            
            #line 270 "..\..\Views\Enquiry\Enquiry.cshtml"
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

        }
    }
}
#pragma warning restore 1591
