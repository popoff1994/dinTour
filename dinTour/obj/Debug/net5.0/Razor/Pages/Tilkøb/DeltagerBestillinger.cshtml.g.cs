#pragma checksum "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f272645a2f35cda4dc950a5a89068443a89270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(dinTour.Pages.Tilkøb.Pages_Tilkøb_DeltagerBestillinger), @"mvc.1.0.razor-page", @"/Pages/Tilkøb/DeltagerBestillinger.cshtml")]
namespace dinTour.Pages.Tilkøb
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f272645a2f35cda4dc950a5a89068443a89270", @"/Pages/Tilkøb/DeltagerBestillinger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50c7656b81ce0f23e469029a1de2a52579b76566", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tilkøb_DeltagerBestillinger : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h1 class=""outlinetext"" style=""color: gray"">Deltager Bestillinger</h1>
<br />
<h5 class=""outlinetext"" style=""color: gray"">Deltager parkering bookninger</h5>
<div class=""test"">
<table class=""table table-bordered"" width=""60%"">
    <thead>
        <tr class=""btn-secondary active"">
            <th>Booknings Id</th>
            <th>Parkerings Id </th>
            <th>DeltagerID</th>
            <th>Deltager Navn</th>
            <th>Booknings Tidspunkt</th>


        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
     if (@Model.CurrentBookings != null)
    {
        foreach (var order in Model.CurrentBookings)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"btn-secondary\">\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
               Write(order.BookingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
               Write(order.ParkeringId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
               Write(order.DeltagerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
               Write(order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
               Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>
</div>
    <h5 class=""outlinetext"" style=""color: gray"">Deltager Menu bestillinger</h5>
    <div class=""test"">
    <table class=""table table-bordered"" width=""60%"">
        <thead>
        <tr class=""btn-secondary active"">
            <th>Tilkøbs Id</th>
            <th>Menu Id</th>
            <th>Dit DeltagerId</th>
            <th>Menu</th>
            <th>Dit Navn</th>
            <th>Antal</th>
            <th>Champagne Menu</th>
            <th>Bestillings Tidspunkt</th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 58 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
         if (@Model.CurrentBookings != null)
        {
            foreach (var order in Model.CurrentTilkøb)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"btn-secondary\">\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.TlkøbId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.VIPId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.DeltagerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.Menu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    <td>");
#nullable restore
#line 73 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 75 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 77 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.ChampagneMenu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
                   Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\Jonas\Source\Repos\dinTour\dinTour\Pages\Tilkøb\DeltagerBestillinger.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dinTour.Pages.Tilkøb.DeltagerBestillingerModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dinTour.Pages.Tilkøb.DeltagerBestillingerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<dinTour.Pages.Tilkøb.DeltagerBestillingerModel>)PageContext?.ViewData;
        public dinTour.Pages.Tilkøb.DeltagerBestillingerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
