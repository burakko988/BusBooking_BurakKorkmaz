#pragma checksum "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "977d2d01554917a986fb40133f1f67a18812bc4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Search), @"mvc.1.0.view", @"/Views/Ticket/Search.cshtml")]
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
#line 1 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using BiletRezervasyon.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977d2d01554917a986fb40133f1f67a18812bc4b", @"/Views/Ticket/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22bad5dd2f8f0a19eee000baac99c53c4b423e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TicketDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""container"">
    <h3 class=""text-center"">Ticket Details</h3><br />
    <hr />
    <table class=""table table table-bordered shadow-sm"">
        <thead>
            <tr>
                <th style=""width:40px;"">Pnr No</th>
                <th style=""width:200px;"">Name - Surname</th>
                <th");
            BeginWriteAttribute("style", " style=\"", 325, "\"", 333, 0);
            EndWriteAttribute();
            WriteLiteral(">Mail</th>\n                <th");
            BeginWriteAttribute("style", " style=\"", 364, "\"", 372, 0);
            EndWriteAttribute();
            WriteLiteral(">Phone</th>\n                <th");
            BeginWriteAttribute("style", " style=\"", 404, "\"", 412, 0);
            EndWriteAttribute();
            WriteLiteral(">Identity</th>\n                <th");
            BeginWriteAttribute("style", " style=\"", 447, "\"", 455, 0);
            EndWriteAttribute();
            WriteLiteral(@">Gender</th>
                <th style=""width:105px;"">Boarding Point</th>
                <th style=""width:105px;"">Destination</th>
                <th style=""width:60px;"">Seat No</th>
                <th style=""width:80px;"">Delete</th>
                

            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 24 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PnrNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PassengerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
                                         Write(Model.PassgerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td>");
#nullable restore
#line 27 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PassengerMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PassengerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PassengerIdentity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.PassengerGender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.BoardingPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 33 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
               Write(Model.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977d2d01554917a986fb40133f1f67a18812bc4b9384", async() => {
                WriteLiteral("\n                                <input type=\"hidden\" name=\"ticketId\"");
                BeginWriteAttribute("value", " value=\"", 1385, "\"", 1408, 1);
#nullable restore
#line 36 "C:\Users\korkk\OneDrive\Masaüstü\Asp.NetCore_Otobus_Bilet_Rezervasyon\BiletRezervasyon.WebUI\Views\Ticket\Search.cshtml"
WriteAttributeValue("", 1393, Model.TicketId, 1393, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                                <button type=\"submit\" class=\"btn btn-sm btn-danger\">Delete</button>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </td>
                

                

            </tr>
        </tbody>
    </table>
    <center>
    <img src=""https://sc04.alicdn.com/kf/UTB8VHyqoL2JXKJkSanr7613lVXaw.png""  style=""width:700px; height:700px; "" />
    </center>
</div>
    
  ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591