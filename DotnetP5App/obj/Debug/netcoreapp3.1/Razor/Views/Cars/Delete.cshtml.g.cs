#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7d2e6a85ccc70b18c668412b8d0a9b5b8241991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Delete), @"mvc.1.0.view", @"/Views/Cars/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7d2e6a85ccc70b18c668412b8d0a9b5b8241991", @"/Views/Cars/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotnetP5App.Models.Car>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d2e6a85ccc70b18c668412b8d0a9b5b82419914338", async() => {
                WriteLiteral("<i class=\"far fa-arrow-alt-circle-left\"></i>");
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
            WriteLiteral(@"
</p>
<div class=""container"" style=""margin-top:30px"">
    <div class=""card w-75"">
        <div class=""card-body"">
            <h5 class=""card-title"">Card title</h5>
            <p class=""card-text"">
                <dl class=""row"">
                    <dt class=""col-sm-3"">
                        ");
#nullable restore
#line 17 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 20 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 23 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 29 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Trim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Trim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 35 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 38 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 41 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 47 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 50 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Vin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 53 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 56 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.PurchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 59 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 62 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.PurchaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-3\">\r\n                        ");
#nullable restore
#line 65 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.LotDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-9\">\r\n                        ");
#nullable restore
#line 68 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.LotDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7d2e6a85ccc70b18c668412b8d0a9b5b824199112967", async() => {
                WriteLiteral("\r\n                ");
#nullable restore
#line 73 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Cars\Delete.cshtml"
           Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Confirm\" class=\"btn btn-warning\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>    \r\n</div>\r\n");
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
