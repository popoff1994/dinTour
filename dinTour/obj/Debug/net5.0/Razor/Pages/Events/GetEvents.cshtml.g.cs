#pragma checksum "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9017928015c22145788be1964ea759410a8338d"
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
#line 1 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\_ViewImports.cshtml"
using dinTour;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9017928015c22145788be1964ea759410a8338d", @"/Pages/Events/GetEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c7656b81ce0f23e469029a1de2a52579b76566", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Events_GetEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1>Events</h1>
<table>
    <col style=""width: 7%"">
    <col style=""width: 74%"">
    <col style=""width: 10%"">
    <thead>
        <tr class=""btn-secondary active"">
            <th>
                <div class=""d-flex justify-content-between p-0"">
                    <div><h5>Parkerings plads Nr.</h5></div>
                </div>
            </th>
            <th>
                <div class=""d-flex justify-content-between p-0"">
                    <div>
                        <h5>Optaget</h5>
                    </div>
                </div>
            </th>
            <th>
                <div class=""d-flex justify-content-between p-0"">
                    <div>
                        <h5>Pris</h5>
                    </div>
                </div>
            </th>
            <th>
                <div class=""d-flex justify-content-between p-0"">
                    <div>
                        <h5>Actions</h5>
                    </div>
                </div>
            </");
            WriteLiteral("th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 41 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
         if (@Model.Musik != null)
        {
            foreach (var item in Model.Musik)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"btn-secondary\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                   Write(item.Navn);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                   Write(item.Varrighed);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
                   Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Jonas\OneDrive\Skrivebord\Github\dinTour\dinTour\Pages\Events\GetEvents.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
