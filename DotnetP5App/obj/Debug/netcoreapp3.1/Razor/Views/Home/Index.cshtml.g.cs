#pragma checksum "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7d6b8e5a6f05a8577fb4d1c8543195975598618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d6b8e5a6f05a8577fb4d1c8543195975598618", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45316172bc775d901e5bb71a61cb2aeddadb9f46", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DotnetP5App.ViewModels.DetailCarViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\JulienBassin\Documents\openclassrooms\Openclassrooms\DotnetP5App\DotnetP5App\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""jumbotron text-center"" style=""margin-top: 90px"">
    <div class=""container-fluid"">
        <h1 class=""jumbotron-heading""> Get your car!</h1>
        <p class=""lead text-muted"">Buy New and Used car all around the world !</p>
        <p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d6b8e5a6f05a8577fb4d1c85431959755986184675", async() => {
                WriteLiteral("Contact Us!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </p>
    </div>
</section>

<div class=""container text-center mb-5"">
    <br> <br>
    <h2 class=""jumbotron-heading"">The best place to tell people why they are here</h2>
    <p class=""text-muted"">
        The difference between involvement and commitment is like an eggs-and-ham breakfast:<br>
        the chicken was involved; the pig was committed.
    </p>
</div>
<!-- /Intro-->

<div class=""jumbotron top-space jb"">
    <div>
        <h3 class=""text-center jumbotron-heading"">Reasons to use this template</h3>
        <div class=""row"">
            <div class=""col-md-3 col-sm-6 highlight"">
                <div class=""h-caption"">
                    <h4><i class=""fa fa-cogs fa-5""></i>Bootstrap-powered</h4>
                </div>
                <div class=""h-body text-center"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Atque aliquid adipisci aspernatur. Soluta quisquam dignissimos earum quasi voluptate. Amet, dignissimos, tenetur vitae dolor q");
            WriteLiteral(@"uam iusto assumenda hic reprehenderit?</p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6 highlight"">
                <div class=""h-caption"">
                    <h4><i class=""fas fa-bolt fa-5 ""></i>Fat-free</h4>
                </div>
                <div class=""h-body text-center"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Asperiores, commodi, sequi quis ad fugit omnis cumque a libero error nesciunt molestiae repellat quos perferendis numquam quibusdam rerum repellendus laboriosam reprehenderit! </p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6 highlight"">
                <div class=""h-caption"">
                    <h4><i class=""fa fa-heart fa-5""></i>Creative Commons</h4>
                </div>
                <div class=""h-body text-center"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptatem, vitae, perferendis, perspiciatis nobis volupt");
            WriteLiteral(@"ate quod illum soluta minima ipsam ratione quia numquam eveniet eum reprehenderit dolorem dicta nesciunt corporis?</p>
                </div>
            </div>
            <div class=""col-md-3 col-sm-6 highlight"">
                <div class=""h-caption"">
                    <h4><i class=""far fa-smile""></i>Author's support</h4>
                </div>
                <div class=""h-body text-center"">
                    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Alias, excepturi, maiores, dolorem quasi reprehenderit illo accusamus nulla minima repudiandae quas ducimus reiciendis odio sequi atque temporibus facere corporis eos expedita? </p>
                </div>
            </div>
        </div> <!-- /row  -->
    </div>
</div>

<div class=""container mt-5"">

    <h2 class=""text-center jumbotron-heading"">Frequently Asked Questions</h2>
    <br>

    <div class=""row"">
        <div class=""col-sm-6"">
            <h3 class=""jumbotron-heading"">Which code editor would you recomm");
            WriteLiteral(@"end?</h3>
            <p>I'd highly recommend you <a href=""http://www.sublimetext.com/"">Sublime Text</a> - a free to try text editor which I'm using daily. Awesome tool!</p>
        </div>
        <div class=""col-sm-6"">
            <h3 class=""jumbotron-heading"">Nice header. Where do I find more images like that one?</h3>
            <p>
                Well, there are thousands of stock art galleries, but personally,
                I prefer to use photos from these sites: <a href=""http://unsplash.com"">Unsplash.com</a>
                and <a href=""http://www.flickr.com/creativecommons/by-2.0/tags/"">Flickr - Creative Commons</a>
            </p>
        </div>
    </div> <!-- /row -->

    <div class=""row"">
        <div class=""col-sm-6"">
            <h3 class=""jumbotron-heading"">Can I use it to build a site for my client?</h3>
            <p>
                Yes, you can. You may use this template for any purpose, just don't forget about the <a href=""http://creativecommons.org/licenses/by/3.0/");
            WriteLiteral(@""">license</a>,
                which says: ""You must give appropriate credit"", i.e. you must provide the name of the creator and a link to the original template in your work.
            </p>
        </div>
        <div class=""col-sm-6"">
            <h3 class=""jumbotron-heading"">Can you customize this template for me?</h3>
            <p>Yes, I can. Please drop me a line to sergey-at-pozhilov.com and describe your needs in details. Please note, my services are not cheap.</p>
        </div>
    </div> <!-- /row -->

    <div class=""jumbotron top-space jb display-3"" style=""margin-bottom:100px"">
        <h4>Dicta, nostrum nemo soluta sapiente sit dolor quae voluptas quidem doloribus recusandae facere magni ullam suscipit sunt atque rerum eaque iusto facilis esse nam veniam incidunt officia perspiciatis at voluptatibus. Libero, aliquid illum possimus numquam fuga.</h4>
        <p class=""text-right""><a class=""btn btn-primary btn-large"">Learn more &raquo;</a></p>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DotnetP5App.ViewModels.DetailCarViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
