#pragma checksum "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3b37488a679b9b20189194d935d7cc017de568"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), @"mvc.1.0.razor-page", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/ClientRestaurants.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_ClientRestaurants), null)]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3b37488a679b9b20189194d935d7cc017de568", @"/Pages/Restaurants/ClientRestaurants.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fe10e6c90f307728f15587f1d83247c98c9355", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_ClientRestaurants : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Development\ASP.NET Projects\OdeToFood\OdeToFood\OdeToFood\Pages\Restaurants\ClientRestaurants.cshtml"
  
    ViewData["Title"] = "ClientRestaurants";

#line default
#line hidden
            BeginContext(119, 87, true);
            WriteLiteral("\r\n<h2>Client Restaurants</h2>\r\n\r\n<table class=\"table\" id=\"restaurants\">\r\n\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(223, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(229, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3b37488a679b9b20189194d935d7cc017de5684399", async() => {
                    BeginContext(264, 15, true);
                    WriteLiteral("\r\n       \r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(293, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(301, 290, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3b37488a679b9b20189194d935d7cc017de5685910", async() => {
                    BeginContext(336, 241, true);
                    WriteLiteral("\r\n        <link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/v/bs/dt-1.11.3/datatables.min.css\" />\r\n        <script type=\"text/javascript\" src=\"https://cdn.datatables.net/v/bs/dt-1.11.3/datatables.min.js\"></script>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(591, 343, true);
                WriteLiteral(@"
        <script>
            const { get } = require(""jquery"");

            $(function () {
                $.ajax(""/api/restaurants/"",
                    { method: ""get"" })
                    .then(function (response) {
                        console.dir(response)
                    });

            });
        </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.ClientRestaurantsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.ClientRestaurantsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
