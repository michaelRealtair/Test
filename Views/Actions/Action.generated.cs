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
    
    #line 4 "..\..\Views\Actions\Action.cshtml"
    using Realtair.Framework.Core.Actions;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Actions\Action.cshtml"
    using Realtair.Framework.Core.Entities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Actions\Action.cshtml"
    using Realtair.Framework.Core.Interfaces;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Actions\Action.cshtml"
    using Realtair.Framework.Core.Web.Utilities;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Actions/Action.cshtml")]
    public partial class _Views_Actions_Action_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Web.Controllers.ActionsController.ActionViewModel>
    {
        public _Views_Actions_Action_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Actions\Action.cshtml"
  
    var detailsTemplate = "-";

    if (Model.Action.This != null)
    {
        detailsTemplate = $"{Model.Action.This.ActualType().Name}/{Model.Action.GetType().Name}";
    }

    if (Html.ViewExists(detailsTemplate))
    {
        Layout = null;
        Html.RenderPartial(detailsTemplate, Model.Action);
    }
    else
    {
        IEnumerable<Field> shown;
        IEnumerable<Field> hidden;

        TempData["ShowSubmit"] = true;

        if (Model.IsMultiPage)
        {
            shown = Model.FieldsForPage;
            hidden = Model.HiddenFieldsForPage;
        }
        else
        {
            shown = Model.Fields;
            hidden = null;
        }


        
            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Actions\Action.cshtml"
   Write(Html.Partial("Menu"));

            
            #line default
            #line hidden
            
            #line 39 "..\..\Views\Actions\Action.cshtml"
                             


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"page-wrapper\"");

WriteLiteral(" class=\"with-background\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"panel panel-default\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"panel-heading\"");

WriteLiteral(">");

            
            #line 44 "..\..\Views\Actions\Action.cshtml"
                                          Write(Model.Action.Description(Html.LoggedInUser()).ToUpper());

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n                    <form");

WriteLiteral(" class=\"autoform form-horizontal\"");

WriteLiteral(" id=\"main-form\"");

WriteLiteral(" method=\"post\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"panel-body\"");

WriteLiteral(">\r\n");

            
            #line 47 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 47 "..\..\Views\Actions\Action.cshtml"
                             if (Model.Action.HasValidated && !Model.Action.IsValid)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"col-md-12\"");

WriteLiteral(">\r\n");

            
            #line 50 "..\..\Views\Actions\Action.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Actions\Action.cshtml"
                                     foreach (var error in Model.Action.Errors.Where(e => e.MemberNames.Count() == 0))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <p");

WriteLiteral(" class=\"brand-danger\"");

WriteLiteral(">");

            
            #line 52 "..\..\Views\Actions\Action.cshtml"
                                                           Write(error.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 53 "..\..\Views\Actions\Action.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </div>\r\n");

            
            #line 55 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 57 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 57 "..\..\Views\Actions\Action.cshtml"
                             foreach (var field in shown)
                            {
                                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Views\Actions\Action.cshtml"
                                  
                                    var fieldWithReturnType = $"Fields/_{field.PropertyType.Name}_{field.FieldAttribute.GetType().Name.Substring(0, field.FieldAttribute.GetType().Name.Length - "Attribute".Length)}";
                                    var fieldWithoutReturnType = $"Fields/_{field.FieldAttribute.GetType().Name.Substring(0, field.FieldAttribute.GetType().Name.Length - "Attribute".Length)}";

                                    if (Html.ViewExists(fieldWithReturnType))
                                    {
                                        Html.RenderPartial(fieldWithReturnType, field);
                                    }
                                    else if (Html.ViewExists(fieldWithoutReturnType))
                                    {
                                        Html.RenderPartial(fieldWithoutReturnType, field);
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <p>Cannot render field view, looked for b" +
"oth ");

            
            #line 73 "..\..\Views\Actions\Action.cshtml"
                                                                                Write(fieldWithReturnType);

            
            #line default
            #line hidden
WriteLiteral(" and ");

            
            #line 73 "..\..\Views\Actions\Action.cshtml"
                                                                                                         Write(fieldWithoutReturnType);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 74 "..\..\Views\Actions\Action.cshtml"
                                    }
                                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Actions\Action.cshtml"
                                 
                                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 78 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 78 "..\..\Views\Actions\Action.cshtml"
                             if (hidden != null)
                            {
                                foreach (var field in hidden)
                                {
                                    if (field.FieldAttribute is Realtair.Framework.Core.Actions.FieldAttributes.BulkFileUploadFieldAttribute && field.Value is IEnumerable<Attachment>)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 3771), Tuple.Create("\"", 3795)
            
            #line 84 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 3778), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 3778), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 3796), Tuple.Create("\"", 3882)
, Tuple.Create(Tuple.Create("", 3804), Tuple.Create("[", 3804), true)
, Tuple.Create(Tuple.Create("", 3805), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 84 "..\..\Views\Actions\Action.cshtml"
                                                                                               foreach (var a in field.Value as IEnumerable<Attachment>) { 
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Actions\Action.cshtml"
                                                                                                                     WriteTo(__razor_attribute_value_writer, a.Id + ",");

            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Actions\Action.cshtml"
                                                                                                                                                                         }
            
            #line default
            #line hidden
}), 3805), false)
, Tuple.Create(Tuple.Create("", 3881), Tuple.Create("]", 3881), true)
);

WriteLiteral(" />\r\n");

            
            #line 85 "..\..\Views\Actions\Action.cshtml"
                                    }
                                    else if (field.Value is IList<Attachment>)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 4106), Tuple.Create("\"", 4130)
            
            #line 88 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 4113), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 4113), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4131), Tuple.Create("\"", 4222)
, Tuple.Create(Tuple.Create("", 4139), Tuple.Create("[", 4139), true)
            
            #line 88 "..\..\Views\Actions\Action.cshtml"
               , Tuple.Create(Tuple.Create("", 4140), Tuple.Create<System.Object, System.Int32>(string.Join(",",((IList<Attachment>)field.Value).Select(f => f.Id.ToString()))
            
            #line default
            #line hidden
, 4140), false)
, Tuple.Create(Tuple.Create("", 4221), Tuple.Create("]", 4221), true)
);

WriteLiteral(" />\r\n");

            
            #line 89 "..\..\Views\Actions\Action.cshtml"
                                    }
                                    else if (field.Value is ICustomViewModel)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 4445), Tuple.Create("\"", 4469)
            
            #line 92 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 4452), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 4452), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4470), Tuple.Create("\"", 4526)
            
            #line 92 "..\..\Views\Actions\Action.cshtml"
              , Tuple.Create(Tuple.Create("", 4478), Tuple.Create<System.Object, System.Int32>((field.Value as ICustomViewModel).Serialize()
            
            #line default
            #line hidden
, 4478), false)
);

WriteLiteral(" />\r\n");

            
            #line 93 "..\..\Views\Actions\Action.cshtml"
                                    }
                                    else if (field.Value is IEnumerable<ICustomViewModel>)
                                    {
                                        if ((field.Value as IEnumerable<ICustomViewModel>).Count() > 0)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 4914), Tuple.Create("\"", 4938)
            
            #line 98 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 4921), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 4921), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4939), Tuple.Create("\"", 5043)
, Tuple.Create(Tuple.Create("", 4947), Tuple.Create("[", 4947), true)
            
            #line 98 "..\..\Views\Actions\Action.cshtml"
                   , Tuple.Create(Tuple.Create("", 4948), Tuple.Create<System.Object, System.Int32>(string.Join(",", (field.Value as IEnumerable<ICustomViewModel>).Select(s => s.Serialize()))
            
            #line default
            #line hidden
, 4948), false)
, Tuple.Create(Tuple.Create("", 5042), Tuple.Create("]", 5042), true)
);

WriteLiteral(" />\r\n");

            
            #line 99 "..\..\Views\Actions\Action.cshtml"
                                        }
                                    }
                                    else if (field.Value is Entity)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 5299), Tuple.Create("\"", 5323)
            
            #line 103 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5306), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 5306), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5324), Tuple.Create("\"", 5361)
            
            #line 103 "..\..\Views\Actions\Action.cshtml"
              , Tuple.Create(Tuple.Create("", 5332), Tuple.Create<System.Object, System.Int32>((field.Value as Entity).Id
            
            #line default
            #line hidden
, 5332), false)
);

WriteLiteral(" />\r\n");

            
            #line 104 "..\..\Views\Actions\Action.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 5547), Tuple.Create("\"", 5571)
            
            #line 107 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5554), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 5554), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5572), Tuple.Create("\"", 5592)
            
            #line 107 "..\..\Views\Actions\Action.cshtml"
             , Tuple.Create(Tuple.Create("", 5580), Tuple.Create<System.Object, System.Int32>(field.Value
            
            #line default
            #line hidden
, 5580), false)
);

WriteLiteral(" />\r\n");

            
            #line 108 "..\..\Views\Actions\Action.cshtml"
                                    }
                                }


            
            #line default
            #line hidden
WriteLiteral("                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"submittedpagenames\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5752), Tuple.Create("\"", 5829)
            
            #line 111 "..\..\Views\Actions\Action.cshtml"
      , Tuple.Create(Tuple.Create("", 5760), Tuple.Create<System.Object, System.Int32>(string.Join(",", Model.SubmittedPages.Select(p => p.GetType().Name))
            
            #line default
            #line hidden
, 5760), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5899), Tuple.Create("\"", 5933)
            
            #line 112 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5907), Tuple.Create<System.Object, System.Int32>(Model.Page.GetType().Name
            
            #line default
            #line hidden
, 5907), false)
);

WriteLiteral(" />\r\n");

            
            #line 113 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" style=\"position: absolute; left: -9999px; width: 1px; height: 1px;\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </form>\r\n\r\n");

            
            #line 119 "..\..\Views\Actions\Action.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 119 "..\..\Views\Actions\Action.cshtml"
                     if ((bool)TempData["ShowSubmit"] || Model.SubmittedPages.Count != 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

            
            #line 122 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\Actions\Action.cshtml"
                             if ((bool)TempData["ShowSubmit"])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <button data-next");

WriteLiteral(" class=\"btn btn-primary pull-right\"");

WriteLiteral(" id=\"main-form-submit\"");

WriteLiteral(">");

            
            #line 124 "..\..\Views\Actions\Action.cshtml"
                                                                                                      Write(Model.Action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 125 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 127 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 127 "..\..\Views\Actions\Action.cshtml"
                             if (Model.SubmittedPages.Count != 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <button");

WriteLiteral(" class=\"btn btn-default pull-right\"");

WriteLiteral(" onclick=\'$(\"#back-form\").submit();\'");

WriteLiteral(">Back</button>\r\n");

            
            #line 130 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n                        </div>\r\n");

            
            #line 134 "..\..\Views\Actions\Action.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 136 "..\..\Views\Actions\Action.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Actions\Action.cshtml"
                     if (Model.IsMultiPage)
                {
                    if (Model.SubmittedPages.Count != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                            <form");

WriteLiteral(" method=\"post\"");

WriteLiteral(" id=\"back-form\"");

WriteLiteral(">\r\n");

            
            #line 141 "..\..\Views\Actions\Action.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 141 "..\..\Views\Actions\Action.cshtml"
                                 if (hidden != null)
                                {
                                    foreach (var field in hidden)
                                    {
                                        if (field.FieldAttribute is Realtair.Framework.Core.Actions.FieldAttributes.BulkFileUploadFieldAttribute && field.Value is IEnumerable<Attachment>)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 7697), Tuple.Create("\"", 7721)
            
            #line 147 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 7704), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 7704), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 7722), Tuple.Create("\"", 7808)
, Tuple.Create(Tuple.Create("", 7730), Tuple.Create("[", 7730), true)
, Tuple.Create(Tuple.Create("", 7731), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 147 "..\..\Views\Actions\Action.cshtml"
                                                                                                   foreach (var a in field.Value as IEnumerable<Attachment>) { 
            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Actions\Action.cshtml"
                                                                                                                         WriteTo(__razor_attribute_value_writer, a.Id + ",");

            
            #line default
            #line hidden
            
            #line 147 "..\..\Views\Actions\Action.cshtml"
                                                                                                                                                                             }
            
            #line default
            #line hidden
}), 7731), false)
, Tuple.Create(Tuple.Create("", 7807), Tuple.Create("]", 7807), true)
);

WriteLiteral(" />\r\n");

            
            #line 148 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else if (field.Value is IEnumerable<Attachment>)
                                        {
                                            foreach (var file in (IEnumerable<Attachment>)field.Value)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 8209), Tuple.Create("\"", 8233)
            
            #line 153 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 8216), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 8216), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 8234), Tuple.Create("\"", 8252)
            
            #line 153 "..\..\Views\Actions\Action.cshtml"
                      , Tuple.Create(Tuple.Create("", 8242), Tuple.Create<System.Object, System.Int32>(file.Id
            
            #line default
            #line hidden
, 8242), false)
);

WriteLiteral(" />\r\n");

            
            #line 154 "..\..\Views\Actions\Action.cshtml"
                                            }
                                        }
                                        else if (field.Value is ICustomViewModel)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 8538), Tuple.Create("\"", 8562)
            
            #line 158 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 8545), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 8545), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 8563), Tuple.Create("\"", 8619)
            
            #line 158 "..\..\Views\Actions\Action.cshtml"
                  , Tuple.Create(Tuple.Create("", 8571), Tuple.Create<System.Object, System.Int32>((field.Value as ICustomViewModel).Serialize()
            
            #line default
            #line hidden
, 8571), false)
);

WriteLiteral(" />\r\n");

            
            #line 159 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else if (field.Value is IEnumerable<ICustomViewModel>)
                                        {
                                            if ((field.Value as IEnumerable<ICustomViewModel>).Count() > 0)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 9031), Tuple.Create("\"", 9055)
            
            #line 164 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 9038), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 9038), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9056), Tuple.Create("\"", 9160)
, Tuple.Create(Tuple.Create("", 9064), Tuple.Create("[", 9064), true)
            
            #line 164 "..\..\Views\Actions\Action.cshtml"
                       , Tuple.Create(Tuple.Create("", 9065), Tuple.Create<System.Object, System.Int32>(string.Join(",", (field.Value as IEnumerable<ICustomViewModel>).Select(s => s.Serialize()))
            
            #line default
            #line hidden
, 9065), false)
, Tuple.Create(Tuple.Create("", 9159), Tuple.Create("]", 9159), true)
);

WriteLiteral(" />\r\n");

            
            #line 165 "..\..\Views\Actions\Action.cshtml"
                                            }
                                        }
                                        else if (field.Value is Entity)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 9436), Tuple.Create("\"", 9460)
            
            #line 169 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 9443), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 9443), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9461), Tuple.Create("\"", 9498)
            
            #line 169 "..\..\Views\Actions\Action.cshtml"
                  , Tuple.Create(Tuple.Create("", 9469), Tuple.Create<System.Object, System.Int32>((field.Value as Entity).Id
            
            #line default
            #line hidden
, 9469), false)
);

WriteLiteral(" />\r\n");

            
            #line 170 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 9700), Tuple.Create("\"", 9724)
            
            #line 173 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 9707), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 9707), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9725), Tuple.Create("\"", 9745)
            
            #line 173 "..\..\Views\Actions\Action.cshtml"
                 , Tuple.Create(Tuple.Create("", 9733), Tuple.Create<System.Object, System.Int32>(field.Value
            
            #line default
            #line hidden
, 9733), false)
);

WriteLiteral(" />\r\n");

            
            #line 174 "..\..\Views\Actions\Action.cshtml"
                                        }
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"submittedpagenames\"");

WriteAttribute("value", Tuple.Create(" value=\"", 9915), Tuple.Create("\"", 9992)
            
            #line 176 "..\..\Views\Actions\Action.cshtml"
          , Tuple.Create(Tuple.Create("", 9923), Tuple.Create<System.Object, System.Int32>(string.Join(",", Model.SubmittedPages.Select(p => p.GetType().Name))
            
            #line default
            #line hidden
, 9923), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 10066), Tuple.Create("\"", 10100)
            
            #line 177 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 10074), Tuple.Create<System.Object, System.Int32>(Model.Page.GetType().Name
            
            #line default
            #line hidden
, 10074), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"back\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n");

            
            #line 179 "..\..\Views\Actions\Action.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </form>\r\n");

            
            #line 181 "..\..\Views\Actions\Action.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n");

WriteLiteral(@"        <script>
            $('#main-form-submit').click(function (e) {
                e.preventDefault()
                var bValid = true;
                $(document).find('input.required:visible').each(function () {
                    var formgroup = $(this).closest('.form-group');
                    if ($(this).val() === '') {
                        formgroup.addClass('has-error');
                        var label = formgroup.find('label.control-label').text();

                        console.log(formgroup.find('div').index(0));
                        if ($(this).closest('.col-md-9').find('span.help-block').length == 0)
                            $(this).closest('.col-md-9').append('<span class=""help-block"">The ' + label + ' field is required.</span>');

                        bValid = false;
                    } else {
                        formgroup.removeClass('has-error');
                        formgroup.find('span.help-block').remove();
                    }
                });

                if (bValid) {
                    $('.preloader').css('display', 'block');
                    $('#main-form').submit.disabled = true;
                    $('#main-form').submit();
                }
            });
        </script>
");

            
            #line 215 "..\..\Views\Actions\Action.cshtml"
                                    }

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
