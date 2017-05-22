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
    
    #line 1 "..\..\Views\Enquiry\Timeline.cshtml"
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Enquiry\Timeline.cshtml"
    using Realtair.Framework.Enquiries.Entities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Enquiry/Timeline.cshtml")]
    public partial class _Views_Enquiry_Timeline_cshtml : System.Web.Mvc.WebViewPage<IEnumerable<Realtair.Framework.Core.Interfaces.ITimelineItem>>
    {

#line 132 "..\..\Views\Enquiry\Timeline.cshtml"
public System.Web.WebPages.HelperResult Render(object describable)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 133 "..\..\Views\Enquiry\Timeline.cshtml"
 
if (describable == null)
{
        

#line default
#line hidden

#line 136 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, "N/A");


#line default
#line hidden

#line 136 "..\..\Views\Enquiry\Timeline.cshtml"
                
}
else if (describable is string)
{
        

#line default
#line hidden

#line 140 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, describable);


#line default
#line hidden

#line 140 "..\..\Views\Enquiry\Timeline.cshtml"
                    
}
else if (describable is decimal || describable is double || describable is int)
{
        

#line default
#line hidden

#line 144 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, describable.ToString());


#line default
#line hidden

#line 144 "..\..\Views\Enquiry\Timeline.cshtml"
                               
}
else if (describable is DateTime)
{
        

#line default
#line hidden

#line 148 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, ((DateTime)describable).ToString("d MMM yyyy"));


#line default
#line hidden

#line 148 "..\..\Views\Enquiry\Timeline.cshtml"
                                                         ;
}
else if (describable is IEnumerable<IDisplayable> || describable is IEnumerable<IHasDisplayable> || describable is IEnumerable<Enquiry>)
{
    var d = describable as IEnumerable<IDescribable>;
    for (int i = 0; i < d.Count(); i++)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 6847), Tuple.Create("\"", 6902)

#line 155 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 6854), Tuple.Create<System.Object, System.Int32>(d.ElementAt(i).GetUrl(Html.LoggedInUser(), Url)

#line default
#line hidden
, 6854), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 155 "..\..\Views\Enquiry\Timeline.cshtml"
                                         WriteTo(__razor_helper_writer, d.ElementAt(i).Description(Html.LoggedInUser()));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 156 "..\..\Views\Enquiry\Timeline.cshtml"

        if (i < d.Count() - 1)
        {
                

#line default
#line hidden

#line 159 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, " & ");


#line default
#line hidden

#line 159 "..\..\Views\Enquiry\Timeline.cshtml"
                        ;
        }
    }
}
else if (describable is IDisplayable || describable is IHasDisplayable || describable is Enquiry)
{


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        <a");

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 7163), Tuple.Create("\"", 7235)

#line 165 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 7170), Tuple.Create<System.Object, System.Int32>((describable as IDescribable).GetUrl(Html.LoggedInUser(), Url)

#line default
#line hidden
, 7170), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 165 "..\..\Views\Enquiry\Timeline.cshtml"
                                                       WriteTo(__razor_helper_writer, (describable as IDescribable).Description(Html.LoggedInUser()));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\r\n");


#line 166 "..\..\Views\Enquiry\Timeline.cshtml"
}
else if (describable is IEnumerable<IDescribable>)
{
    var d = describable as IEnumerable<IDescribable>;
    for (int i = 0; i < d.Count(); i++)
    {
            

#line default
#line hidden

#line 172 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, d.ElementAt(i).Description(Html.LoggedInUser()));


#line default
#line hidden

#line 172 "..\..\Views\Enquiry\Timeline.cshtml"
                                                            

        if (i < d.Count() - 1)
        {
                

#line default
#line hidden

#line 176 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, " & ");


#line default
#line hidden

#line 176 "..\..\Views\Enquiry\Timeline.cshtml"
                        ;
        }
    }
}
else if (describable is IDescribable)
{
        

#line default
#line hidden

#line 182 "..\..\Views\Enquiry\Timeline.cshtml"
WriteTo(__razor_helper_writer, (describable as IDescribable).Description(Html.LoggedInUser()));


#line default
#line hidden

#line 182 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                         
}



#line default
#line hidden
});

#line 185 "..\..\Views\Enquiry\Timeline.cshtml"
}
#line default
#line hidden

        public _Views_Enquiry_Timeline_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Enquiry\Timeline.cshtml"
   Layout = ""; 
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 6 "..\..\Views\Enquiry\Timeline.cshtml"
   var attachmentId = 0; 
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<ul");

WriteLiteral(" class=\"chat-list slimscroll p-t-30\"");

WriteLiteral(">\r\n");

            
            #line 9 "..\..\Views\Enquiry\Timeline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Enquiry\Timeline.cshtml"
     foreach (var timelineItem in Model)
    {
        if (timelineItem is TimelineEvent)
        {
            var thisState = timelineItem as TimelineEvent;

            var typeString = "";
            if (thisState.Type == TimelineEvent.EventType.Progress)
            {
                typeString = "panel-success";
            }

            if (thisState.Type == TimelineEvent.EventType.Info)
            {
                typeString = "panel-info";
            }

            if (thisState.Type == TimelineEvent.EventType.Warning)
            {
                typeString = "panel-warning";
            }

            if (thisState.Type == TimelineEvent.EventType.Exception)
            {
                typeString = "panel-danger";
            }


            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteAttribute("class", Tuple.Create(" class=\"", 1055), Tuple.Create("\"", 1127)
            
            #line 36 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 1063), Tuple.Create<System.Object, System.Int32>(thisState.UserResponsible == Html.LoggedInUser() ? "odd" : ""
            
            #line default
            #line hidden
, 1063), false)
);

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"chat-image\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" alt=\"Female\"");

WriteLiteral(" src=\"http://static.realtair.com/plugins/images/users/genu.jpg\"");

WriteLiteral(">\r\n                </div>\r\n                <div");

WriteAttribute("class", Tuple.Create(" class=\"", 1320), Tuple.Create("\"", 1355)
, Tuple.Create(Tuple.Create("", 1328), Tuple.Create("chat-body", 1328), true)
, Tuple.Create(Tuple.Create(" ", 1337), Tuple.Create("panel", 1338), true)
            
            #line 40 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create(" ", 1343), Tuple.Create<System.Object, System.Int32>(typeString
            
            #line default
            #line hidden
, 1344), false)
);

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"panel-heading text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 42 "..\..\Views\Enquiry\Timeline.cshtml"
                   Write(thisState.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n\r\n");

            
            #line 45 "..\..\Views\Enquiry\Timeline.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Enquiry\Timeline.cshtml"
                     if (thisState.Details(Html.LoggedInUser()).Count() > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"panel-wrapper collapse in\"");

WriteLiteral(" aria-expanded=\"true\"");

WriteLiteral(">\r\n                            <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n                                <ul>\r\n");

            
            #line 50 "..\..\Views\Enquiry\Timeline.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Enquiry\Timeline.cshtml"
                                     foreach (var describable in thisState.Details(Html.LoggedInUser()))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <li><strong>");

            
            #line 52 "..\..\Views\Enquiry\Timeline.cshtml"
                                               Write(describable.Key);

            
            #line default
            #line hidden
WriteLiteral(":</strong>\t");

            
            #line 52 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                           Write(Render(describable.Value));

            
            #line default
            #line hidden
WriteLiteral("</li>\r\n");

            
            #line 53 "..\..\Views\Enquiry\Timeline.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </ul>\r\n                            </div>\r\n      " +
"                  </div>\r\n");

            
            #line 57 "..\..\Views\Enquiry\Timeline.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 59 "..\..\Views\Enquiry\Timeline.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Enquiry\Timeline.cshtml"
                     if (thisState.Actions().WithAccess(Html.LoggedInUser(), ViewContext.DbContext()).Count() > 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

            
            #line 62 "..\..\Views\Enquiry\Timeline.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Enquiry\Timeline.cshtml"
                             foreach (var action in thisState.Actions().WithAccess(Html.LoggedInUser(), ViewContext.DbContext()))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <form");

WriteLiteral(" class=\"inline\"");

WriteAttribute("action", Tuple.Create(" action=\"", 2631), Tuple.Create("\"", 2659)
            
            #line 64 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 2640), Tuple.Create<System.Object, System.Int32>(action.GetUrl(Url)
            
            #line default
            #line hidden
, 2640), false)
);

WriteAttribute("method", Tuple.Create(" method=\"", 2660), Tuple.Create("\"", 2715)
            
            #line 64 "..\..\Views\Enquiry\Timeline.cshtml"
           , Tuple.Create(Tuple.Create("", 2669), Tuple.Create<System.Object, System.Int32>(action.Fields.Count() >= 1 ? "GET" : "POST"
            
            #line default
            #line hidden
, 2669), false)
);

WriteLiteral(">\r\n                                    <input");

WriteLiteral(" name=\"ReturnUrl\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2792), Tuple.Create("\"", 2825)
            
            #line 65 "..\..\Views\Enquiry\Timeline.cshtml"
 , Tuple.Create(Tuple.Create("", 2800), Tuple.Create<System.Object, System.Int32>(Request.Url.AbsolutePath
            
            #line default
            #line hidden
, 2800), false)
);

WriteLiteral(" />\r\n                                    <button");

WriteLiteral(" class=\"btn btn-sm btn-default btn-rounded m-l-5 m-r-5\"");

WriteLiteral(" type=\"submit\"");

WriteLiteral(">");

            
            #line 66 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                                                            Write(action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n                                </form>\r\n");

            
            #line 68 "..\..\Views\Enquiry\Timeline.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n");

            
            #line 70 "..\..\Views\Enquiry\Timeline.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 72 "..\..\Views\Enquiry\Timeline.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 72 "..\..\Views\Enquiry\Timeline.cshtml"
                     if (thisState is IShowAttachments)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"file-attachment text-center panel-footer\"");

WriteLiteral(">\r\n");

            
            #line 75 "..\..\Views\Enquiry\Timeline.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Enquiry\Timeline.cshtml"
                             foreach (var attachment in (thisState as IShowAttachments).Attachments)
                            {
                                if (attachment.IsImage)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3547), Tuple.Create("\"", 3575)
            
            #line 79 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 3554), Tuple.Create<System.Object, System.Int32>(attachment.GetUrl(0)
            
            #line default
            #line hidden
, 3554), false)
);

WriteLiteral(" class=\"gallery-item text-center\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3609), Tuple.Create("\"", 3627)
            
            #line 79 "..\..\Views\Enquiry\Timeline.cshtml"
                         , Tuple.Create(Tuple.Create("", 3614), Tuple.Create<System.Object, System.Int32>(attachmentId
            
            #line default
            #line hidden
, 3614), false)
);

WriteLiteral(" itemprop=\"associatedMedia\"");

WriteLiteral(" itemscope=\"\"");

WriteLiteral(" itemtype=\"http://schema.org/ImageObject\"");

WriteLiteral(" data-pid=\"");

            
            #line 79 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                                                                                                                                                              Write(attachmentId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-caption=\"\"");

WriteLiteral(" data-width=\"1600\"");

WriteLiteral(" data-height=\"1200\"");

WriteLiteral(">\r\n                                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 3834), Tuple.Create("\"", 3873)
            
            #line 80 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 3840), Tuple.Create<System.Object, System.Int32>(Html.Raw(attachment.GetUrl(100))
            
            #line default
            #line hidden
, 3840), false)
);

WriteLiteral(" style=\"width: 100px !important; height: 100px !important;\"");

WriteLiteral(" alt=\"#\"");

WriteLiteral(" itemprop=\"thumbnail\"");

WriteLiteral(">\r\n                                    </a>\r\n");

            
            #line 82 "..\..\Views\Enquiry\Timeline.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4153), Tuple.Create("\"", 4181)
            
            #line 85 "..\..\Views\Enquiry\Timeline.cshtml"
, Tuple.Create(Tuple.Create("", 4160), Tuple.Create<System.Object, System.Int32>(attachment.GetUrl(0)
            
            #line default
            #line hidden
, 4160), false)
);

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(">\r\n                                        <img");

WriteLiteral(" src=\"https://realtair.com/Content/img/icon-pdf.png\"");

WriteLiteral(" alt=\"#\"");

WriteLiteral(" width=\"80\"");

WriteLiteral(" height=\"80\"");

WriteLiteral(">\r\n                                    </a>\r\n");

            
            #line 88 "..\..\Views\Enquiry\Timeline.cshtml"
                                }
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </div>\r\n");

            
            #line 91 "..\..\Views\Enquiry\Timeline.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </li>\r\n");

            
            #line 95 "..\..\Views\Enquiry\Timeline.cshtml"
        }
        else if (timelineItem is Message)
        {
            var thisMessage = timelineItem as Message;

            if (thisMessage.User != Html.LoggedInUser())
            {

            
            #line default
            #line hidden
WriteLiteral("                <li>\r\n                    <div");

WriteLiteral(" class=\"chat-image\"");

WriteLiteral("> <img");

WriteLiteral(" alt=\"Female\"");

WriteLiteral(" src=\"http://static.realtair.com/plugins/images/users/genu.jpg\"");

WriteLiteral("> </div>\r\n                    <div");

WriteLiteral(" class=\"chat-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"chat-text\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 106 "..\..\Views\Enquiry\Timeline.cshtml"
                           Write(thisMessage.User.Person.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p> ");

            
            #line 107 "..\..\Views\Enquiry\Timeline.cshtml"
                           Write(Html.TextToHtml(thisMessage.Content));

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n                            <b>");

            
            #line 108 "..\..\Views\Enquiry\Timeline.cshtml"
                          Write(thisMessage.TimelineDate.UTCToLocal().ToString("d MMM yyyy"));

            
            #line default
            #line hidden
WriteLiteral(" <span> - ");

            
            #line 108 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                                                 Write(thisMessage.TimelineDate.UTCToLocal().ToString("h:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("</span></b>\r\n                        </div>\r\n                    </div>\r\n        " +
"        </li>\r\n");

            
            #line 112 "..\..\Views\Enquiry\Timeline.cshtml"
            }
            else
            {

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"odd\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"chat-image\"");

WriteLiteral("> <img");

WriteLiteral(" alt=\"male\"");

WriteLiteral(" src=\"http://static.realtair.com/plugins/images/users/varun.jpg\"");

WriteLiteral("> </div>\r\n                    <div");

WriteLiteral(" class=\"chat-body\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"chat-text\"");

WriteLiteral(">\r\n                            <h4>");

            
            #line 119 "..\..\Views\Enquiry\Timeline.cshtml"
                           Write(thisMessage.User.Person.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                            <p> ");

            
            #line 120 "..\..\Views\Enquiry\Timeline.cshtml"
                           Write(Html.TextToHtml(thisMessage.Content));

            
            #line default
            #line hidden
WriteLiteral(" </p>\r\n                            <b>");

            
            #line 121 "..\..\Views\Enquiry\Timeline.cshtml"
                          Write(thisMessage.TimelineDate.UTCToLocal().ToString("d MMM yyyy"));

            
            #line default
            #line hidden
WriteLiteral(" <span> - ");

            
            #line 121 "..\..\Views\Enquiry\Timeline.cshtml"
                                                                                                 Write(thisMessage.TimelineDate.UTCToLocal().ToString("h:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("</span></b>\r\n                        </div>\r\n                    </div>\r\n        " +
"        </li>\r\n");

            
            #line 125 "..\..\Views\Enquiry\Timeline.cshtml"
            }
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n\r\n\r\n\r\n");

        }
    }
}
#pragma warning restore 1591
