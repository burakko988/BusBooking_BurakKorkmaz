#pragma checksum "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44a19c32413cb2bdd12a331cc027df0ce40595a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_FindRoute), @"mvc.1.0.view", @"/Views/Ticket/FindRoute.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44a19c32413cb2bdd12a331cc027df0ce40595a6", @"/Views/Ticket/FindRoute.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22bad5dd2f8f0a19eee000baac99c53c4b423e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ticket_FindRoute : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Route>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetTicketsFromRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h2 class=\"text-center display-4\">Routes</h2>\r\n");
#nullable restore
#line 5 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <h1>No results were found for the expedition you were looking for, <a href=""#"">please contact us.</a></h1>
        <center>
            <img src=""https://sc04.alicdn.com/kf/UTB8VHyqoL2JXKJkSanr7613lVXaw.png"" style=""width:700px; height:700px; "" />
        </center>
");
#nullable restore
#line 11 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44a19c32413cb2bdd12a331cc027df0ce40595a65519", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"card text-center mt-4\">\r\n                <div class=\"card-header\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral(" on ");
#nullable restore
#line 17 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             Write(ViewBag.From);

#line default
#line hidden
#nullable disable
                WriteLiteral(" to ");
#nullable restore
#line 17 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                              Write(ViewBag.toWhere);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">Price:  <i class=\"fa-solid fa-turkish-lira-sign\"> </i>");
#nullable restore
#line 20 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                                                                            Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n                    <h5 class=\"card-title\">Departure Time:");
#nullable restore
#line 21 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                                     Write(item.Hour);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1002, "\"", 1023, 1);
#nullable restore
#line 22 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 1010, item.RouteId, 1010, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <h5 class=\"card-title\">Bus Driver: ");
#nullable restore
#line 23 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                                  Write(item.Bus.BusDriverFullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Bus Plaque: ");
#nullable restore
#line 24 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                                  Write(item.Bus.BusPlaque);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <h5 class=\"card-title\">Bus Seat Capacity: ");
#nullable restore
#line 25 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                                         Write(item.Bus.BusSeatCapacity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                    <div");
                BeginWriteAttribute("class", " class=\"", 1317, "\"", 1325, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <ul class=\"list-group list-group-horizontal d-flex justify-content-center border-none\">\r\n\r\n                            <li class=\"list-group-item\">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                 if (ViewBag.From == item.FirstTerminal)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <strong>");
#nullable restore
#line 33 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                       Write(item.FirstTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1747, "\"", 1774, 1);
#nullable restore
#line 34 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 1755, item.FirstTerminal, 1755, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 35 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>");
#nullable restore
#line 38 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                  Write(item.FirstTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </p>\r\n");
#nullable restore
#line 39 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </li>\r\n");
#nullable restore
#line 41 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             if (item.Terminal1 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item\">\r\n");
#nullable restore
#line 44 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                     if (ViewBag.From == item.Terminal1)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 46 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2445, "\"", 2468, 1);
#nullable restore
#line 47 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 2453, item.Terminal1, 2453, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 48 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else if (ViewBag.toWhere == item.Terminal1)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 51 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" =></strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2787, "\"", 2810, 1);
#nullable restore
#line 52 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 2795, item.Terminal1, 2795, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 53 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>");
#nullable restore
#line 56 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                      Write(item.Terminal1);

#line default
#line hidden
#nullable disable
                WriteLiteral(" =></p>\r\n");
#nullable restore
#line 57 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n");
#nullable restore
#line 59 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             if (item.Terminal2 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item\">\r\n");
#nullable restore
#line 63 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                     if (ViewBag.From == item.Terminal2)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 65 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3529, "\"", 3552, 1);
#nullable restore
#line 66 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 3537, item.Terminal2, 3537, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 67 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else if (ViewBag.toWhere == item.Terminal2)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 70 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 3872, "\"", 3895, 1);
#nullable restore
#line 71 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 3880, item.Terminal2, 3880, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 72 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>");
#nullable restore
#line 75 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                      Write(item.Terminal2);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </p>\r\n");
#nullable restore
#line 76 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n");
#nullable restore
#line 78 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             if (item.Terminal3 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item\">\r\n");
#nullable restore
#line 82 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                     if (ViewBag.From == item.Terminal3)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 84 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4615, "\"", 4638, 1);
#nullable restore
#line 85 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 4623, item.Terminal3, 4623, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 86 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else if (ViewBag.toWhere == item.Terminal3)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 89 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 4958, "\"", 4981, 1);
#nullable restore
#line 90 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 4966, item.Terminal3, 4966, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 91 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>");
#nullable restore
#line 94 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                      Write(item.Terminal3);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </p>\r\n");
#nullable restore
#line 95 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n");
#nullable restore
#line 97 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             if (item.Terminal4 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item\">\r\n\r\n");
#nullable restore
#line 102 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                     if (ViewBag.From == item.Terminal4)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 104 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal4);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 5703, "\"", 5726, 1);
#nullable restore
#line 105 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 5711, item.Terminal4, 5711, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 106 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else if (ViewBag.toWhere == item.Terminal4)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 109 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal4);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6046, "\"", 6069, 1);
#nullable restore
#line 110 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 6054, item.Terminal4, 6054, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 111 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>");
#nullable restore
#line 114 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                      Write(item.Terminal4);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </p>\r\n");
#nullable restore
#line 115 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n");
#nullable restore
#line 117 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                             if (item.Terminal5 != null)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"list-group-item\">\r\n\r\n");
#nullable restore
#line 122 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                     if (ViewBag.From == item.Terminal5)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 124 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal5);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 6791, "\"", 6814, 1);
#nullable restore
#line 125 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 6799, item.Terminal5, 6799, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"startCity\" />\r\n");
#nullable restore
#line 126 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else if (ViewBag.toWhere == item.Terminal5)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <strong>");
#nullable restore
#line 129 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                           Write(item.Terminal5);

#line default
#line hidden
#nullable disable
                WriteLiteral(" => </strong>\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7134, "\"", 7157, 1);
#nullable restore
#line 130 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 7142, item.Terminal5, 7142, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 131 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <p>");
#nullable restore
#line 134 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                      Write(item.Terminal5);

#line default
#line hidden
#nullable disable
                WriteLiteral(" =></p>\r\n");
#nullable restore
#line 135 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n");
#nullable restore
#line 137 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li class=\"list-group-item\">\r\n");
#nullable restore
#line 139 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                 if (ViewBag.toWhere == item.LastTerminal)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <strong>");
#nullable restore
#line 141 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                       Write(item.LastTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </strong>\r\n                                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 7774, "\"", 7800, 1);
#nullable restore
#line 142 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
WriteAttributeValue("", 7782, item.LastTerminal, 7782, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"endCity\" />\r\n");
#nullable restore
#line 143 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <p>");
#nullable restore
#line 146 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                  Write(item.LastTerminal);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </p>\r\n");
#nullable restore
#line 147 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary mt-3\">Select Seat</button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 154 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\FindRoute.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Route>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
