#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Greeting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d740f7dfb7b617fbf7352fd433ab6953df0919c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Greeting_Index), @"mvc.1.0.view", @"/Views/Greeting/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Greeting/Index.cshtml", typeof(AspNetCore.Views_Greeting_Index))]
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
#line 1 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App;

#line default
#line hidden
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\_ViewImports.cshtml"
using DotnetP5App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d740f7dfb7b617fbf7352fd433ab6953df0919c7", @"/Views/Greeting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Greeting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DotnetP5App.Models.GreetingViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Greeting\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
            BeginContext(108, 13, false);
#line 8 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Greeting\Index.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(121, 3, true);
            WriteLiteral("!, ");
            EndContext();
            BeginContext(125, 10, false);
#line 8 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetEnglishP5\DotnetP5App\Views\Greeting\Index.cshtml"
            Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(135, 3, true);
            WriteLiteral("!\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DotnetP5App.Models.GreetingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591