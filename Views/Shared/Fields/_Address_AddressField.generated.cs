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
    using System.Collections;
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
    
    #line 1 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
    using Realtair.Framework.Core.Entities;
    
    #line default
    #line hidden
    using Realtair.Framework.Core.Interfaces;
    using Realtair.Framework.Core.Web.Utilities;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Fields/_Address_AddressField.cshtml")]
    public partial class _Views_Shared_Fields__Address_AddressField_cshtml : System.Web.Mvc.WebViewPage<Realtair.Framework.Core.Actions.Field>
    {
        public _Views_Shared_Fields__Address_AddressField_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
  
    Address Address = null;
    if (Model.Value != null)
    {
        Address = (Address)Model?.Value;
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 10 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
 if (Model.HasError)
{

            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"form-address-mob\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-group has-error\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral(">");

            
            #line 14 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                         Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 463), Tuple.Create("\"", 494)
            
            #line 16 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 468), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 468), false)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("_line_1", 487), true)
);

WriteLiteral(" placeholder=\"Address Line 1\"");

WriteAttribute("value", Tuple.Create(" value=\"", 524), Tuple.Create("\"", 556)
            
            #line 16 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                               , Tuple.Create(Tuple.Create("", 532), Tuple.Create<System.Object, System.Int32>(Address?.AddressLine1
            
            #line default
            #line hidden
, 532), false)
);

WriteLiteral(">\r\n            <small>");

            
            #line 17 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
              Write(Model.FieldAttribute.Help);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteAttribute("class", Tuple.Create(" class=\"", 687), Tuple.Create("\"", 756)
, Tuple.Create(Tuple.Create("", 695), Tuple.Create("col-sm-", 695), true)
            
            #line 21 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 702), Tuple.Create<System.Object, System.Int32>(Model.Label.Count() > 40 ? "12" : "3"
            
            #line default
            #line hidden
, 702), false)
, Tuple.Create(Tuple.Create(" ", 742), Tuple.Create("control-label", 743), true)
);

WriteLiteral("></label>\r\n        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 856), Tuple.Create("\"", 887)
            
            #line 23 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 861), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 861), false)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("_line_2", 880), true)
);

WriteLiteral(" placeholder=\"Address Line 2\"");

WriteAttribute("value", Tuple.Create(" value=\"", 917), Tuple.Create("\"", 949)
            
            #line 23 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                               , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(Address?.AddressLine2
            
            #line default
            #line hidden
, 925), false)
);

WriteLiteral(">\r\n            <small></small>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group has-error\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral("></label>\r\n        <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1194), Tuple.Create("\"", 1225)
            
            #line 30 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 1199), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1199), false)
, Tuple.Create(Tuple.Create("", 1218), Tuple.Create("_suburb", 1218), true)
);

WriteLiteral(" placeholder=\"Suburb\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1247), Tuple.Create("\"", 1273)
            
            #line 30 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                      , Tuple.Create(Tuple.Create("", 1255), Tuple.Create<System.Object, System.Int32>(Address?.Suburb
            
            #line default
            #line hidden
, 1255), false)
);

WriteLiteral(">\r\n            <span");

WriteLiteral(" class=\"help-block has-error\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                          Write(Model.ErrorMessage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1465), Tuple.Create("\"", 1495)
            
            #line 34 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 1470), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1470), false)
, Tuple.Create(Tuple.Create("", 1489), Tuple.Create("_state", 1489), true)
);

WriteLiteral(" placeholder=\"State\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1516), Tuple.Create("\"", 1541)
            
            #line 34 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                    , Tuple.Create(Tuple.Create("", 1524), Tuple.Create<System.Object, System.Int32>(Address?.State
            
            #line default
            #line hidden
, 1524), false)
);

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-xs-6 col-sm-2\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1658), Tuple.Create("\"", 1691)
            
            #line 37 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 1663), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 1663), false)
, Tuple.Create(Tuple.Create("", 1682), Tuple.Create("_postcode", 1682), true)
);

WriteLiteral(" placeholder=\"Post Code\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1716), Tuple.Create("\"", 1744)
            
            #line 37 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                           , Tuple.Create(Tuple.Create("", 1724), Tuple.Create<System.Object, System.Int32>(Address?.Postcode
            
            #line default
            #line hidden
, 1724), false)
);

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n");

            
            #line 41 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
}
else
{
            
            #line default
            #line hidden
WriteLiteral("<div");

WriteLiteral(" class=\"form-address-mob\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteAttribute("class", Tuple.Create(" class=\"", 1870), Tuple.Create("\"", 1939)
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create("col-sm-", 1878), true)
            
            #line 45 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(Model.Label.Count() > 40 ? "12" : "3"
            
            #line default
            #line hidden
, 1885), false)
, Tuple.Create(Tuple.Create(" ", 1925), Tuple.Create("control-label", 1926), true)
);

WriteLiteral(">");

            
            #line 45 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                                                                Write(Model.Label);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2051), Tuple.Create("\"", 2082)
            
            #line 47 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 2056), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 2056), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("_line_1", 2075), true)
);

WriteLiteral(" placeholder=\"Address Line 1\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2112), Tuple.Create("\"", 2144)
            
            #line 47 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                              , Tuple.Create(Tuple.Create("", 2120), Tuple.Create<System.Object, System.Int32>(Address?.AddressLine1
            
            #line default
            #line hidden
, 2120), false)
);

WriteLiteral(">\r\n            <small>");

            
            #line 48 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
              Write(Model.FieldAttribute.Help);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral("></label>\r\n        <div");

WriteLiteral(" class=\"col-sm-9\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2405), Tuple.Create("\"", 2436)
            
            #line 54 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 2410), false)
, Tuple.Create(Tuple.Create("", 2429), Tuple.Create("_line_2", 2429), true)
);

WriteLiteral(" placeholder=\"Address Line 2\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2466), Tuple.Create("\"", 2498)
            
            #line 54 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                              , Tuple.Create(Tuple.Create("", 2474), Tuple.Create<System.Object, System.Int32>(Address?.AddressLine2
            
            #line default
            #line hidden
, 2474), false)
);

WriteLiteral(">\r\n            <small></small>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"col-sm-3 control-label\"");

WriteLiteral("></label>\r\n        <div");

WriteLiteral(" class=\"col-sm-4\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2733), Tuple.Create("\"", 2764)
            
            #line 61 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 2738), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 2738), false)
, Tuple.Create(Tuple.Create("", 2757), Tuple.Create("_suburb", 2757), true)
);

WriteLiteral(" placeholder=\"Suburb\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2786), Tuple.Create("\"", 2812)
            
            #line 61 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                      , Tuple.Create(Tuple.Create("", 2794), Tuple.Create<System.Object, System.Int32>(Address?.Suburb
            
            #line default
            #line hidden
, 2794), false)
);

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-xs-6 col-sm-3 address-mobile\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 2944), Tuple.Create("\"", 2974)
            
            #line 64 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 2949), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 2949), false)
, Tuple.Create(Tuple.Create("", 2968), Tuple.Create("_state", 2968), true)
);

WriteLiteral(" placeholder=\"State\"");

WriteAttribute("value", Tuple.Create(" value=\"", 2995), Tuple.Create("\"", 3020)
            
            #line 64 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                    , Tuple.Create(Tuple.Create("", 3003), Tuple.Create<System.Object, System.Int32>(Address?.State
            
            #line default
            #line hidden
, 3003), false)
);

WriteLiteral(">\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"col-xs-6 col-sm-2 address-mobile\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control lite\"");

WriteAttribute("id", Tuple.Create(" id=\"", 3152), Tuple.Create("\"", 3185)
            
            #line 67 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3157), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3157), false)
, Tuple.Create(Tuple.Create("", 3176), Tuple.Create("_postcode", 3176), true)
);

WriteLiteral(" placeholder=\"Post Code\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3210), Tuple.Create("\"", 3238)
            
            #line 67 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                           , Tuple.Create(Tuple.Create("", 3218), Tuple.Create<System.Object, System.Int32>(Address?.Postcode
            
            #line default
            #line hidden
, 3218), false)
);

WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    </div>\r\n");

            
            #line 71 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 3303), Tuple.Create("\"", 3338)
            
            #line 74 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3308), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3308), false)
, Tuple.Create(Tuple.Create("", 3327), Tuple.Create("_streetName", 3327), true)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3353), Tuple.Create("\"", 3383)
            
            #line 74 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3361), Tuple.Create<System.Object, System.Int32>(Address?.StreetName
            
            #line default
            #line hidden
, 3361), false)
);

WriteLiteral(">\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 3397), Tuple.Create("\"", 3432)
            
            #line 75 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3402), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3402), false)
, Tuple.Create(Tuple.Create("", 3421), Tuple.Create("_streetType", 3421), true)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3447), Tuple.Create("\"", 3477)
            
            #line 75 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3455), Tuple.Create<System.Object, System.Int32>(Address?.StreetType
            
            #line default
            #line hidden
, 3455), false)
);

WriteLiteral(">\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\"", 3491), Tuple.Create("\"", 3528)
            
            #line 76 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3496), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3496), false)
, Tuple.Create(Tuple.Create("", 3515), Tuple.Create("_streetNumber", 3515), true)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3543), Tuple.Create("\"", 3575)
            
            #line 76 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3551), Tuple.Create<System.Object, System.Int32>(Address?.StreetNumber
            
            #line default
            #line hidden
, 3551), false)
);

WriteLiteral(">\r\n    <input");

WriteAttribute("name", Tuple.Create(" name=\"", 3589), Tuple.Create("\"", 3613)
            
            #line 77 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3596), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3596), false)
);

WriteAttribute("id", Tuple.Create(" id=\"", 3614), Tuple.Create("\"", 3636)
            
            #line 77 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
, Tuple.Create(Tuple.Create("", 3619), Tuple.Create<System.Object, System.Int32>(Model.UniqueName
            
            #line default
            #line hidden
, 3619), false)
);

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 3651), Tuple.Create("\"", 3705)
, Tuple.Create(Tuple.Create("", 3659), Tuple.Create<System.Object, System.Int32>(new System.Web.WebPages.HelperResult(__razor_attribute_value_writer => {

            
            #line 77 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                                                                 if (Address != null) { 
            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                                                 WriteTo(__razor_attribute_value_writer, Address.Serialize());

            
            #line default
            #line hidden
            
            #line 77 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                                                                                                             }
            
            #line default
            #line hidden
}), 3659), false)
);

WriteLiteral(" />\r\n\r\n\r\n    <script>\r\n(function () {\r\n    var serialised = document.getElementBy" +
"Id(\'");

            
            #line 82 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                         Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("\')\r\n    var line_1 = document.getElementById(\'");

            
            #line 83 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                      Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_line_1\');\r\n    var line_2 = document.getElementById(\'");

            
            #line 84 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                      Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_line_2\');\r\n    var suburb = document.getElementById(\'");

            
            #line 85 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                      Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_suburb\');\r\n    var state = document.getElementById(\'");

            
            #line 86 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                     Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_state\');\r\n    var postcode = document.getElementById(\'");

            
            #line 87 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                        Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_postcode\');\r\n    var streetNumber = document.getElementById(\'");

            
            #line 88 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                            Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_streetNumber\');\r\n    var streetName = document.getElementById(\'");

            
            #line 89 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                          Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_streetName\');\r\n    var streetType = document.getElementById(\'");

            
            #line 90 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                                          Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_streetType\');\r\n\r\n    var widget, initAF = function () {\r\n    widget = new Addres" +
"sFinder.Widget(\r\n        document.getElementById(\'");

            
            #line 94 "..\..\Views\Shared\Fields\_Address_AddressField.cshtml"
                             Write(Model.UniqueName);

            
            #line default
            #line hidden
WriteLiteral("_line_1\'),\r\n        \'YVBDJGHTNMLPEW46K73Q\',\r\n        \'AU\',\r\n    {\r\n    });\r\n\r\n   " +
" widget.on(\'result:select\', function (fullAddress, metaData) {\r\n        line_1.v" +
"alue = metaData.address_line_1;\r\n        line_2.value = metaData.address_line_2;" +
"\r\n        suburb.value = metaData.locality_name;\r\n        state.value = metaData" +
".state_territory;\r\n        postcode.value = metaData.postcode;\r\n        streetNu" +
"mber.value = getStreetNumber(metaData);\r\n        streetName.value = metaData.str" +
"eet_name;\r\n        streetType.value = metaData.street_type;\r\n        generateJso" +
"n();\r\n        });\r\n    };\r\n\r\n    function getStreetNumber(m) {\r\n        return (" +
"m.street_number_1 && !m.street_number_2) && \'${m.street_number_1}\' ||\r\n         " +
"   ((m.street_number_1 && m.street_number_2) && \'${m.street_number_1}-${m.street" +
"_number_2}\') ||\r\n            (m.lot_identifier);\r\n    }\r\n\r\n    function download" +
"AF(f) {\r\n        var script = document.createElement(\'script\');\r\n        script." +
"src = \'https://api.addressfinder.io/assets/v3/widget.js\';\r\n        script.async " +
"= true;\r\n        script.onload = f;\r\n        document.body.appendChild(script);\r" +
"\n    };\r\n\r\n    document.addEventListener(\'DOMContentLoaded\', function () {\r\n    " +
"    downloadAF(initAF);\r\n    });\r\n\r\n    $(line_1).change(generateJson);\r\n    $(l" +
"ine_2).change(generateJson);\r\n    $(suburb).change(generateJson);\r\n    $(state)." +
"change(generateJson);\r\n    $(postcode).change(generateJson);\r\n    $(streetNumber" +
").change(generateJson);\r\n    $(streetName).change(generateJson);\r\n    $(streetNa" +
"me).change(generateJson);\r\n\r\n    function generateJson() {\r\n        serialised.v" +
"alue = JSON.stringify({\r\n            AddressLine1: line_1.value,\r\n            Ad" +
"dressLine2: line_2.value,\r\n            Suburb: suburb.value,\r\n            Postco" +
"de: postcode.value,\r\n            State: state.value,\r\n            StreetNumber: " +
"streetNumber.value,\r\n            StreetName: streetName.value,\r\n            Stre" +
"etType: streetType.value\r\n        });\r\n    }\r\n})();\r\n    </script>\r\n");

        }
    }
}
#pragma warning restore 1591
