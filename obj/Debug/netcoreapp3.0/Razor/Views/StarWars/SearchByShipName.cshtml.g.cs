#pragma checksum "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9be326d00b09b15307505bbe07de914fee9d4bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StarWars_SearchByShipName), @"mvc.1.0.view", @"/Views/StarWars/SearchByShipName.cshtml")]
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
#line 1 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\_ViewImports.cshtml"
using StarWarsAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\_ViewImports.cshtml"
using StarWarsAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9be326d00b09b15307505bbe07de914fee9d4bb", @"/Views/StarWars/SearchByShipName.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43316e210a7ec667b8efdea540c1bba20d266920", @"/Views/_ViewImports.cshtml")]
    public class Views_StarWars_SearchByShipName : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShipRoot>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet2.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c9be326d00b09b15307505bbe07de914fee9d4bb3841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
  
    ViewData["Title"] = "SearchByShipName";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<h1>SearchByShipName</h1>

<table class=""table-bordered"">

    <tr>
        <th>Name</th>
        <th>Model</th>
        <th>Manufacturer</th>
        <th>Passengers</th>
        <th>Cargo Capacity</th>
        <th>Hyperdrive Rating</th>
    </tr>

    <tr>
        <td>");
#nullable restore
#line 23 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 24 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.manufacturer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.passengers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.cargo_capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\jbenk\Desktop\bootcamp2019\Week 7\StarWarsAPI\Views\StarWars\SearchByShipName.cshtml"
       Write(Model.hyperdrive_rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n     \r\n     \r\n\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShipRoot> Html { get; private set; }
    }
}
#pragma warning restore 1591
