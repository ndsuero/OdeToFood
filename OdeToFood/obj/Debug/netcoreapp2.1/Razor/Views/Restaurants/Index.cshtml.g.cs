#pragma checksum "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9095f01fd2e304848ec834e220e1f05c4197fb35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Index.cshtml", typeof(AspNetCore.Views_Restaurants_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9095f01fd2e304848ec834e220e1f05c4197fb35", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OdeToFood.Core.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(90, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 40, false);
#line 16 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(289, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(345, 44, false);
#line 19 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(389, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(445, 43, false);
#line 22 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(488, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(606, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(655, 39, false);
#line 31 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(694, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(750, 43, false);
#line 34 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location));

#line default
#line hidden
            EndContext();
            BeginContext(793, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(849, 42, false);
#line 37 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(891, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 966, "\"", 989, 1);
#line 40 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
WriteAttributeValue("", 981, item.Id, 981, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1042, "\"", 1065, 1);
#line 41 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
WriteAttributeValue("", 1057, item.Id, 1057, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1066, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1120, "\"", 1143, 1);
#line 42 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
WriteAttributeValue("", 1135, item.Id, 1135, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1144, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Views\Restaurants\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1194, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OdeToFood.Core.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
