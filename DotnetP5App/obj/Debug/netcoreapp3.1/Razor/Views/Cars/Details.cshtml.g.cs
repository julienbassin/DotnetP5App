#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c55ebe39b7c56d667a73712fed55b54842e78aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Details), @"mvc.1.0.view", @"/Views/Cars/Details.cshtml")]
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
#line 1 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c55ebe39b7c56d667a73712fed55b54842e78aa4", @"/Views/Cars/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotnetP5App.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details for ");
#nullable restore
#line 7 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
           Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 12 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 15 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 18 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 21 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 24 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Trim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 27 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Trim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 30 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 33 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 36 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 39 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 42 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 45 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 48 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 51 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 54 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 57 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 60 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LotDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 63 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
       Write(Html.DisplayFor(model => model.LotDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 68 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c55ebe39b7c56d667a73712fed55b54842e78aa410377", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotnetP5App.Models.Car> Html { get; private set; }
    }
}
#pragma warning restore 1591
