#pragma checksum "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a63493fd995516d7d058debcb6b55125ed17f82"
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
#line 1 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\_ViewImports.cshtml"
using dinTour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a63493fd995516d7d058debcb6b55125ed17f82", @"/Pages/Events/GetEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c7656b81ce0f23e469029a1de2a52579b76566", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events_GetEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Add Begivenhed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Events/OpretBegivenhed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "DeleteBegivenhed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1 class=\"outlinetext\" style=\"color:gray\">Begivenheder</h1>\r\n<h3 class=\"outlinetext\" style=\"color: yellow\">Antal tilmeldte til eventet ");
#nullable restore
#line 7 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                                     Write(Model.Deltagere.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p class=\"outlinetext\" style=\"color:yellow\">Eventet tilader op til 500 deltager.</p>\r\n");
#nullable restore
#line 9 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
 if (@Model.Deltagere.Count < 100)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2 class=\"outlinetext\" style=\"color: red\">Bemærk er der under 100 tilmeldte. Vil eventet blive aflyst!</h2>\r\n");
#nullable restore
#line 12 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
 if (HttpContext.User.Identity.Name.Equals("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a63493fd995516d7d058debcb6b55125ed17f827326", async() => {
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
#line 20 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-4 shadow-lg bg-light test2 border2\">\r\n            <h3>MadTelt</h3>\r\n");
#nullable restore
#line 25 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
             if (@Model.Begivenheder != null)
            {
                foreach (var item in Model.Begivenheder)
                {
                    if (item.Location == "MadTelt")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-title\">\r\n                                <h4>Navn på begivenhed: ");
#nullable restore
#line 34 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                   Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h4>Begivenheden Starter kl: ");
#nullable restore
#line 35 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.StartTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h4>Begivenheden Slutter kl: ");
#nullable restore
#line 36 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.EndTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"card-text\">\r\n                                <h4>Beskrivelse:</h4>\r\n                                <p style=\"font-size: 25px\">");
#nullable restore
#line 40 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                      Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                             if (HttpContext.User.Identity.Name.Equals("admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-footer\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a63493fd995516d7d058debcb6b55125ed17f8211619", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                                                                                                                                            WriteLiteral(item.BegivenhedId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 47 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                    }

                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n        <div class=\"col-sm-4 shadow-lg bg-light test2 border2\">\r\n            <h3>Tribune</h3>\r\n");
#nullable restore
#line 59 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
             if (@Model.Begivenheder != null)
            {
                foreach (var item in Model.Begivenheder)
                {
                    if (item.Location == "Tribune")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-title\">\r\n                                <h4>Navn på begivenhed: ");
#nullable restore
#line 68 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                   Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h4>Begivenheden Starter kl: ");
#nullable restore
#line 69 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.StartTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h4>Begivenheden Slutter kl: ");
#nullable restore
#line 70 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.EndTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"card-text\">\r\n                                <h4>Beskrivelse:</h4>\r\n                                <p style=\"font-size: 25px\">");
#nullable restore
#line 74 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                      Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                             if (HttpContext.User.Identity.Name.Equals("admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-footer\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a63493fd995516d7d058debcb6b55125ed17f8217531", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                                                                                                                                            WriteLiteral(item.BegivenhedId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 81 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 83 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                    }

                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n\r\n        <div class=\"col-sm-4 shadow-lg bg-light test2 border2\">\r\n            <h3>MusikTelt</h3>\r\n");
#nullable restore
#line 95 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
             if (@Model.Begivenheder != null)
            {
                foreach (var item in Model.Begivenheder)
                {
                    if (item.Location == "MusikTelt")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card shadow mb-2 mt-1 ym-2\"></div>\r\n                        <div class=\"card-body\">\r\n                            <div class=\"card-title\">\r\n                                <h4>Navn på begivenhed: ");
#nullable restore
#line 104 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                   Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                                <h4>Begivenheden Starter kl: ");
#nullable restore
#line 106 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.StartTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h4>Begivenheden Slutter kl: ");
#nullable restore
#line 107 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                        Write(item.EndTime.TimeOfDay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"card-text\">\r\n                                <h4>Beskrivelse:</h4>\r\n                                <p style=\"font-size: 25px\">");
#nullable restore
#line 111 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                      Write(item.Beskrivelse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 113 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                             if (HttpContext.User.Identity.Name.Equals("admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-footer\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a63493fd995516d7d058debcb6b55125ed17f8223464", async() => {
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                                                                                                                                                                            WriteLiteral(item.BegivenhedId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 118 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 120 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                    }

                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
