#pragma checksum "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8909e1fcdaf57e93fb437b6ab9ceb85a3752275b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__ProductItems), @"mvc.1.0.view", @"/Views/Shared/Partial/_ProductItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/_ProductItems.cshtml", typeof(AspNetCore.Views_Shared_Partial__ProductItems))]
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
#line 1 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\_ViewImports.cshtml"
using WebStore;

#line default
#line hidden
#line 2 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\_ViewImports.cshtml"
using WebStore.DomainEntities.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8909e1fcdaf57e93fb437b6ab9ceb85a3752275b", @"/Views/Shared/Partial/_ProductItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792823c94e626c6a9f7c06f77fc0e7296c099b84", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__ProductItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebStore.DomainEntities.ViewModels.ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(73, 106, true);
            WriteLiteral("\r\n<div class=\"features_items\">\r\n    <!--features_items-->\r\n    <h2 class=\"title text-center\">Товары</h2>\r\n");
            EndContext();
#line 6 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(220, 211, true);
            WriteLiteral("        <div class=\"col-sm-4\">\r\n            <div class=\"product-image-wrapper\">\r\n                <div class=\"single-products\">\r\n                    <div class=\"productinfo text-center\">\r\n                        ");
            EndContext();
            BeginContext(431, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8909e1fcdaf57e93fb437b6ab9ceb85a3752275b4464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 441, "~/images/shop/", 441, 14, true);
#line 12 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
AddHtmlAttributeValue("", 455, item.ImageUrl, 455, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(480, 30, true);
            WriteLiteral("\r\n                        <h2>");
            EndContext();
            BeginContext(511, 24, false);
#line 13 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
                       Write(item.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(535, 34, true);
            WriteLiteral("</h2>\r\n                        <p>");
            EndContext();
            BeginContext(570, 9, false);
#line 14 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
                      Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(579, 303, true);
            WriteLiteral(@"</p>
                        <a href=""#"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</a>
                    </div>
                    <div class=""product-overlay"">
                        <div class=""overlay-content"">
                            <h2>");
            EndContext();
            BeginContext(883, 24, false);
#line 19 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
                           Write(item.Price.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(907, 38, true);
            WriteLiteral("</h2>\r\n                            <p>");
            EndContext();
            BeginContext(946, 9, false);
#line 20 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
                          Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(955, 602, true);
            WriteLiteral(@"</p>
                            <a href=""#"" class=""btn btn-default add-to-cart""><i class=""fa fa-shopping-cart""></i>Добавить в корзину</a>
                        </div>
                    </div>
                </div>
                <div class=""choose"">
                    <ul class=""nav nav-pills nav-justified"">
                        <li><a href=""#""><i class=""fa fa-plus-square""></i>В пожелания</a></li>
                        <li><a href=""#""><i class=""fa fa-plus-square""></i>К сравнению</a></li>
                    </ul>
                </div>
            </div>
        </div>
");
            EndContext();
#line 33 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_ProductItems.cshtml"
    }

#line default
#line hidden
            BeginContext(1564, 27, true);
            WriteLiteral("</div><!--features_items-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebStore.DomainEntities.ViewModels.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
