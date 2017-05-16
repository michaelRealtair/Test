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
WriteLiteral("                                    <p>Cannot render field view, looked for both " +
"");

            
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

WriteAttribute("name", Tuple.Create(" name=\"", 3640), Tuple.Create("\"", 3664)
            
            #line 84 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 3647), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 3647), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 3665), Tuple.Create("\"", 3751)
, Tuple.Create(Tuple.Create("", 3673), Tuple.Create("[", 3673), true)
, Tuple.Create(Tuple.Create("", 3674), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
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
}), 3674), false)
, Tuple.Create(Tuple.Create("", 3750), Tuple.Create("]", 3750), true)
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

WriteAttribute("name", Tuple.Create(" name=\"", 3975), Tuple.Create("\"", 3999)
            
            #line 88 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 3982), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 3982), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4000), Tuple.Create("\"", 4091)
, Tuple.Create(Tuple.Create("", 4008), Tuple.Create("[", 4008), true)
            
            #line 88 "..\..\Views\Actions\Action.cshtml"
               , Tuple.Create(Tuple.Create("", 4009), Tuple.Create<System.Object, System.Int32>(string.Join(",",((IList<Attachment>)field.Value).Select(f => f.Id.ToString()))
            
            #line default
            #line hidden
, 4009), false)
, Tuple.Create(Tuple.Create("", 4090), Tuple.Create("]", 4090), true)
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

WriteAttribute("name", Tuple.Create(" name=\"", 4314), Tuple.Create("\"", 4338)
            
            #line 92 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 4321), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 4321), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4339), Tuple.Create("\"", 4395)
            
            #line 92 "..\..\Views\Actions\Action.cshtml"
              , Tuple.Create(Tuple.Create("", 4347), Tuple.Create<System.Object, System.Int32>((field.Value as ICustomViewModel).Serialize()
            
            #line default
            #line hidden
, 4347), false)
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

WriteAttribute("name", Tuple.Create(" name=\"", 4783), Tuple.Create("\"", 4807)
            
            #line 98 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 4790), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 4790), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 4808), Tuple.Create("\"", 4912)
, Tuple.Create(Tuple.Create("", 4816), Tuple.Create("[", 4816), true)
            
            #line 98 "..\..\Views\Actions\Action.cshtml"
                   , Tuple.Create(Tuple.Create("", 4817), Tuple.Create<System.Object, System.Int32>(string.Join(",", (field.Value as IEnumerable<ICustomViewModel>).Select(s => s.Serialize()))
            
            #line default
            #line hidden
, 4817), false)
, Tuple.Create(Tuple.Create("", 4911), Tuple.Create("]", 4911), true)
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

WriteAttribute("name", Tuple.Create(" name=\"", 5168), Tuple.Create("\"", 5192)
            
            #line 103 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5175), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 5175), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5193), Tuple.Create("\"", 5230)
            
            #line 103 "..\..\Views\Actions\Action.cshtml"
              , Tuple.Create(Tuple.Create("", 5201), Tuple.Create<System.Object, System.Int32>((field.Value as Entity).Id
            
            #line default
            #line hidden
, 5201), false)
);

WriteLiteral(" />\r\n");

            
            #line 104 "..\..\Views\Actions\Action.cshtml"
                                    }
                                    else if (field.FieldAttribute is Realtair.Framework.Core.Actions.FieldAttributes.WidgetFieldAttribute)
                                    {

                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 5636), Tuple.Create("\"", 5660)
            
            #line 111 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5643), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 5643), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 5661), Tuple.Create("\"", 5681)
            
            #line 111 "..\..\Views\Actions\Action.cshtml"
             , Tuple.Create(Tuple.Create("", 5669), Tuple.Create<System.Object, System.Int32>(field.Value
            
            #line default
            #line hidden
, 5669), false)
);

WriteLiteral(" />\r\n");

            
            #line 112 "..\..\Views\Actions\Action.cshtml"
                                    }
                                }


            
            #line default
            #line hidden
WriteLiteral("                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"submittedpagenames\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5841), Tuple.Create("\"", 5918)
            
            #line 115 "..\..\Views\Actions\Action.cshtml"
      , Tuple.Create(Tuple.Create("", 5849), Tuple.Create<System.Object, System.Int32>(string.Join(",", Model.SubmittedPages.Select(p => p.GetType().Name))
            
            #line default
            #line hidden
, 5849), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 5988), Tuple.Create("\"", 6022)
            
            #line 116 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 5996), Tuple.Create<System.Object, System.Int32>(Model.Page.GetType().Name
            
            #line default
            #line hidden
, 5996), false)
);

WriteLiteral(" />\r\n");

            
            #line 117 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" style=\"position: absolute; left: -9999px; width: 1px; height: 1px;\"");

WriteLiteral(" tabindex=\"-1\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </form>\r\n\r\n");

            
            #line 123 "..\..\Views\Actions\Action.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 123 "..\..\Views\Actions\Action.cshtml"
                     if ((bool)TempData["ShowSubmit"] || Model.SubmittedPages.Count != 0)
                {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(">\r\n");

            
            #line 126 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 126 "..\..\Views\Actions\Action.cshtml"
                             if ((bool)TempData["ShowSubmit"])
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <button data-next");

WriteLiteral(" class=\"btn btn-primary pull-right\"");

WriteLiteral(" id=\"main-form-submit\"");

WriteLiteral(">");

            
            #line 128 "..\..\Views\Actions\Action.cshtml"
                                                                                                      Write(Model.Action.Description(Html.LoggedInUser()));

            
            #line default
            #line hidden
WriteLiteral("</button>\r\n");

            
            #line 129 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 131 "..\..\Views\Actions\Action.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 131 "..\..\Views\Actions\Action.cshtml"
                             if (Model.SubmittedPages.Count != 0)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <button");

WriteLiteral(" class=\"btn btn-default pull-right\"");

WriteLiteral(" onclick=\'$(\"#back-form\").submit();\'");

WriteLiteral(">Back</button>\r\n");

            
            #line 134 "..\..\Views\Actions\Action.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral("></div>\r\n                        </div>\r\n");

            
            #line 138 "..\..\Views\Actions\Action.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 140 "..\..\Views\Actions\Action.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 140 "..\..\Views\Actions\Action.cshtml"
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

            
            #line 145 "..\..\Views\Actions\Action.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 145 "..\..\Views\Actions\Action.cshtml"
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

WriteAttribute("name", Tuple.Create(" name=\"", 7786), Tuple.Create("\"", 7810)
            
            #line 151 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 7793), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 7793), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 7811), Tuple.Create("\"", 7897)
, Tuple.Create(Tuple.Create("", 7819), Tuple.Create("[", 7819), true)
, Tuple.Create(Tuple.Create("", 7820), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 151 "..\..\Views\Actions\Action.cshtml"
                                                                                                   foreach (var a in field.Value as IEnumerable<Attachment>) { 
            
            #line default
            #line hidden
            
            #line 151 "..\..\Views\Actions\Action.cshtml"
                                                                                                                         WriteTo(__razor_attribute_value_writer, a.Id + ",");

            
            #line default
            #line hidden
            
            #line 151 "..\..\Views\Actions\Action.cshtml"
                                                                                                                                                                             }
            
            #line default
            #line hidden
}), 7820), false)
, Tuple.Create(Tuple.Create("", 7896), Tuple.Create("]", 7896), true)
);

WriteLiteral(" />\r\n");

            
            #line 152 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else if (field.Value is IEnumerable<Attachment>)
                                        {
                                            foreach (var file in (IEnumerable<Attachment>)field.Value)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 8298), Tuple.Create("\"", 8322)
            
            #line 157 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 8305), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 8305), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 8323), Tuple.Create("\"", 8341)
            
            #line 157 "..\..\Views\Actions\Action.cshtml"
                      , Tuple.Create(Tuple.Create("", 8331), Tuple.Create<System.Object, System.Int32>(file.Id
            
            #line default
            #line hidden
, 8331), false)
);

WriteLiteral(" />\r\n");

            
            #line 158 "..\..\Views\Actions\Action.cshtml"
                                            }
                                        }
                                        else if (field.Value is ICustomViewModel)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 8627), Tuple.Create("\"", 8651)
            
            #line 162 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 8634), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 8634), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 8652), Tuple.Create("\"", 8708)
            
            #line 162 "..\..\Views\Actions\Action.cshtml"
                  , Tuple.Create(Tuple.Create("", 8660), Tuple.Create<System.Object, System.Int32>((field.Value as ICustomViewModel).Serialize()
            
            #line default
            #line hidden
, 8660), false)
);

WriteLiteral(" />\r\n");

            
            #line 163 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else if (field.Value is IEnumerable<ICustomViewModel>)
                                        {
                                            if ((field.Value as IEnumerable<ICustomViewModel>).Count() > 0)
                                            {

            
            #line default
            #line hidden
WriteLiteral("                                                <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 9120), Tuple.Create("\"", 9144)
            
            #line 168 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 9127), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 9127), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9145), Tuple.Create("\"", 9249)
, Tuple.Create(Tuple.Create("", 9153), Tuple.Create("[", 9153), true)
            
            #line 168 "..\..\Views\Actions\Action.cshtml"
                       , Tuple.Create(Tuple.Create("", 9154), Tuple.Create<System.Object, System.Int32>(string.Join(",", (field.Value as IEnumerable<ICustomViewModel>).Select(s => s.Serialize()))
            
            #line default
            #line hidden
, 9154), false)
, Tuple.Create(Tuple.Create("", 9248), Tuple.Create("]", 9248), true)
);

WriteLiteral(" />\r\n");

            
            #line 169 "..\..\Views\Actions\Action.cshtml"
                                            }
                                        }
                                        else if (field.Value is Entity)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 9525), Tuple.Create("\"", 9549)
            
            #line 173 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 9532), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 9532), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 9550), Tuple.Create("\"", 9587)
            
            #line 173 "..\..\Views\Actions\Action.cshtml"
                  , Tuple.Create(Tuple.Create("", 9558), Tuple.Create<System.Object, System.Int32>((field.Value as Entity).Id
            
            #line default
            #line hidden
, 9558), false)
);

WriteLiteral(" />\r\n");

            
            #line 174 "..\..\Views\Actions\Action.cshtml"
                                        }
                                        else if (field.FieldAttribute is Realtair.Framework.Core.Actions.FieldAttributes.WidgetFieldAttribute)
                                        {

                                        }
                                        else
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("name", Tuple.Create(" name=\"", 10021), Tuple.Create("\"", 10045)
            
            #line 181 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 10028), Tuple.Create<System.Object, System.Int32>(field.UniqueName
            
            #line default
            #line hidden
, 10028), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 10046), Tuple.Create("\"", 10066)
            
            #line 181 "..\..\Views\Actions\Action.cshtml"
                , Tuple.Create(Tuple.Create("", 10054), Tuple.Create<System.Object, System.Int32>(field.Value
            
            #line default
            #line hidden
, 10054), false)
);

WriteLiteral(" />\r\n");

            
            #line 182 "..\..\Views\Actions\Action.cshtml"
                                        }
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"submittedpagenames\"");

WriteAttribute("value", Tuple.Create(" value=\"", 10236), Tuple.Create("\"", 10313)
            
            #line 184 "..\..\Views\Actions\Action.cshtml"
         , Tuple.Create(Tuple.Create("", 10244), Tuple.Create<System.Object, System.Int32>(string.Join(",", Model.SubmittedPages.Select(p => p.GetType().Name))
            
            #line default
            #line hidden
, 10244), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 10387), Tuple.Create("\"", 10421)
            
            #line 185 "..\..\Views\Actions\Action.cshtml"
, Tuple.Create(Tuple.Create("", 10395), Tuple.Create<System.Object, System.Int32>(Model.Page.GetType().Name
            
            #line default
            #line hidden
, 10395), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                                    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"back\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />\r\n");

            
            #line 187 "..\..\Views\Actions\Action.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                            </form>\r\n");

            
            #line 189 "..\..\Views\Actions\Action.cshtml"
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

            
            #line 223 "..\..\Views\Actions\Action.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

DefineSection("Scripts", () => {

WriteLiteral("\r\n");

WriteLiteral("    ");

            
            #line 227 "..\..\Views\Actions\Action.cshtml"
Write(Html.RenderDelayed());

            
            #line default
            #line hidden
WriteLiteral(";\r\n");

});

        }
    }
}
#pragma warning restore 1591
