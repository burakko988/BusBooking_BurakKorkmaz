#pragma checksum "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f35c60f11285865d42534d1532bd40cb5b9246c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Succesfully), @"mvc.1.0.view", @"/Views/Ticket/Succesfully.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f35c60f11285865d42534d1532bd40cb5b9246c", @"/Views/Ticket/Succesfully.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c22bad5dd2f8f0a19eee000baac99c53c4b423e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Ticket_Succesfully : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicketModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"container shadow mt-5\" style=\"text-align:center;\">\r\n    <br />\r\n    <i class=\"fas fa-check-circle\" style=\"font-size:36px; color:green;\"></i><br />\r\n    <br /><p> Dear ");
#nullable restore
#line 7 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
              Write(Model.Ticket.PassengerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
                                               Write(Model.Ticket.PassgerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 7 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
                                                                              Write(Model.Ticket.BoardingPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -> ");
#nullable restore
#line 7 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
                                                                                                             Write(Model.Ticket.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" for ticket has been succesful to reservation.</p> <br />
    
    <br /><hr /><br />
    <h3>Ticket Details</h3><br />
    
    <table class=""table table table-bordered shadow-sm"">
        <thead>
            <tr>
                <th style=""width:40px;"">Pnr No</th>
                <th style=""width:200px;"">Name - Surname</th>
                <th");
            BeginWriteAttribute("style", " style=\"", 685, "\"", 693, 0);
            EndWriteAttribute();
            WriteLiteral(">Mail</th>\r\n                <th");
            BeginWriteAttribute("style", " style=\"", 725, "\"", 733, 0);
            EndWriteAttribute();
            WriteLiteral(@">Phone</th>
                <th style=""width:105px;"">Boarding Point</th>
                <th style=""width:105px;"">Destination</th>
                <th style=""width:60px;"">Seat No</th>
                <th style=""width:80px;"">Price</th>
                <th style=""width:100px;"">Date </th>
                <th style=""width:80px;"">Hour</th>
                

            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 31 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.PnrNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.PassengerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
                                                Write(Model.Ticket.PassgerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 34 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.PassengerMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.PassengerPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.BoardingPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Ticket.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\korkk\OneDrive\Masaüstü\BusBooking_BurakKorkmaz\BiletRezervasyon.WebUI\Views\Ticket\Succesfully.cshtml"
               Write(Model.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    <br />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f35c60f11285865d42534d1532bd40cb5b9246c10888", async() => {
                WriteLiteral("Return Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RouteTicketModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
