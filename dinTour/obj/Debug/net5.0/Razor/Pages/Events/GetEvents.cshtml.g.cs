#pragma checksum "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba9f6d93adfaa7e90b9e8e8116c2ab7b9bf122e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dinTour.Pages.Events.Pages_Events_GetEvents), @"mvc.1.0.razor-page", @"/Pages/Events/GetEvents.cshtml")]
namespace dinTour.Pages.Events
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
#line 1 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\_ViewImports.cshtml"
using dinTour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba9f6d93adfaa7e90b9e8e8116c2ab7b9bf122e8", @"/Pages/Events/GetEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c7656b81ce0f23e469029a1de2a52579b76566", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events_GetEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add Begivenhed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Events/OpretBegivenhed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h3>Events</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
 if (HttpContext.User.Identity.Name.Equals("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba9f6d93adfaa7e90b9e8e8116c2ab7b9bf122e84557", async() => {
                WriteLiteral("Opret Begivenhed ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 12 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n<div class=\"row\">\r\n    <div class=\"col-sm-4 shadow-lg bg-light\">\r\n        <h3>MadTelt</h3>\r\n");
#nullable restore
#line 17 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
         if (@Model.Begivenheder != null)
        {
            foreach (var item in Model.Begivenheder)
            {
                if (item.Location == "MadTelt")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            <h4>Navn på begivenhed: ");
#nullable restore
#line 26 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                               Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h4>Begivenheden Starter kl: ");
#nullable restore
#line 27 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                    Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <p style=\"font-size: 25px\">");
#nullable restore
#line 30 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                  Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                         if (HttpContext.User.Identity.Name.Equals("admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-footer\">\r\n                                <p>PLACEHOLDER</p>\r\n                            </div>\r\n");
#nullable restore
#line 37 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 39 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                }

            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n    \r\n    <div class=\"col-sm-4 shadow-lg bg-light\">\r\n        <h3>Tribune</h3>\r\n");
#nullable restore
#line 49 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
         if (@Model.Begivenheder != null)
        {
            foreach (var item in Model.Begivenheder)
            {
                if (item.Location == "Tribune")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            <h4>Navn på begivenhed: ");
#nullable restore
#line 58 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                               Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            <h4>Begivenheden Starter kl: ");
#nullable restore
#line 59 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                    Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <p style=\"font-size: 25px\">");
#nullable restore
#line 62 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                  Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 64 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                         if (HttpContext.User.Identity.Name.Equals("admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-footer\">\r\n                                <p>PLACEHOLDER</p>\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 71 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                }

            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n\r\n    \r\n    \r\n    <div class=\"col-sm-4 shadow-lg bg-light\">\r\n        <h3>MusikTelt</h3>\r\n");
#nullable restore
#line 83 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
         if (@Model.Begivenheder != null)
        {
            foreach (var item in Model.Begivenheder)
            {
                if (item.Location == "MusikTelt")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            <h4>Navn på begivenhed: ");
#nullable restore
#line 92 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                               Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                            <h4>Begivenheden Starter kl: ");
#nullable restore
#line 94 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                    Write(item.StartTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        </div>\r\n                        <div class=\"card-text\">\r\n                            <p style=\"font-size: 25px\">");
#nullable restore
#line 97 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                  Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 99 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                         if (HttpContext.User.Identity.Name.Equals("admin"))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-footer\">\r\n                                <p>PLACEHOLDER</p>\r\n                            </div>\r\n");
#nullable restore
#line 104 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 106 "C:\Users\Jonas\source\repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                }

            }

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dinTour.Pages.Events.GetEventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dinTour.Pages.Events.GetEventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dinTour.Pages.Events.GetEventsModel>)PageContext?.ViewData;
        public dinTour.Pages.Events.GetEventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
