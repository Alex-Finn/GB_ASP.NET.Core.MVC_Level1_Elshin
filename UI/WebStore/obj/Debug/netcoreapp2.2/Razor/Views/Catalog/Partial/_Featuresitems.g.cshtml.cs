#pragma checksum "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Partial__FeaturesItems), @"mvc.1.0.view", @"/Views/Catalog/Partial/_FeaturesItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Partial/_FeaturesItems.cshtml", typeof(AspNetCore.Views_Catalog_Partial__FeaturesItems))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a158", @"/Views/Catalog/Partial/_FeaturesItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0da7d44e6fc850ed9be8ca8602fae6055b5539b", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Partial__FeaturesItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default add-to-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 116, true);
            WriteLiteral("\r\n<div class=\"features_items\">\r\n    <!--features_items-->\r\n    <h2 class=\"title text-center\">Features Items</h2>\r\n\r\n");
            EndContext();
#line 7 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(198, 191, true);
            WriteLiteral("    <div class=\"col-sm-4\">\r\n        <div class=\"product-image-wrapper\">\r\n            <div class=\"single-products\">\r\n                <div class=\"productinfo text-center\">\r\n                    ");
            EndContext();
            BeginContext(389, 309, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a1585824", async() => {
                BeginContext(472, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(498, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a1586227", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 508, "~/images/shop/", 508, 14, true);
#line 14 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
AddHtmlAttributeValue("", 522, product.ImageUrl, 522, 17, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 14 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
AddHtmlAttributeValue("", 546, product.Name, 546, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(563, 30, true);
                WriteLiteral("\r\n                        <h2>");
                EndContext();
                BeginContext(594, 27, false);
#line 15 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                       Write(product.Price.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(621, 34, true);
                WriteLiteral("</h2>\r\n                        <p>");
                EndContext();
                BeginContext(656, 12, false);
#line 16 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                      Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(668, 26, true);
                WriteLiteral("</p>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                                                                              WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(698, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(720, 356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a15811590", async() => {
                BeginContext(971, 101, true);
                WriteLiteral("\r\n                        <i class=\"fa fa-shopping-cart\"></i>Добавить в корзину\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 20 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                         WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 21 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                                WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1076, 148, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"product-overlay\">\r\n                    <div class=\"overlay-content\">\r\n                        ");
            EndContext();
            BeginContext(1224, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a15815236", async() => {
                BeginContext(1307, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1337, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a15815646", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1347, "~/images/shop/", 1347, 14, true);
#line 29 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
AddHtmlAttributeValue("", 1361, product.ImageUrl, 1361, 17, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 29 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
AddHtmlAttributeValue("", 1385, product.Name, 1385, 13, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1402, 34, true);
                WriteLiteral("\r\n                            <h2>");
                EndContext();
                BeginContext(1437, 27, false);
#line 30 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                           Write(product.Price.ToString("C"));

#line default
#line hidden
                EndContext();
                BeginContext(1464, 38, true);
                WriteLiteral("</h2>\r\n                            <p>");
                EndContext();
                BeginContext(1503, 12, false);
#line 31 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                          Write(product.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1515, 30, true);
                WriteLiteral("</p>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1549, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1575, 380, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9f0d4172f44c22bd97ce8ed1c33b1a3dfb4a15821051", async() => {
                BeginContext(1842, 109, true);
                WriteLiteral("\r\n                            <i class=\"fa fa-shopping-cart\"></i>Добавить в корзину\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                             WriteLiteral(product.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 36 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
                                    WriteLiteral(Context.Request.Path);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ReturnUrl", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ReturnUrl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1955, 440, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""choose"">
                <ul class=""nav nav-pills nav-justified"">
                    <li><a href=""""><i class=""fa fa-plus-square""></i>Добавить в список желаний</a></li>
                    <li><a href=""""><i class=""fa fa-plus-square""></i>ДОбавить к сравнению</a></li>
                </ul>
            </div>
        </div>
    </div>
");
            EndContext();
#line 51 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Catalog\Partial\_FeaturesItems.cshtml"
    }

#line default
#line hidden
            BeginContext(2402, 230, true);
            WriteLiteral("\r\n    <ul class=\"pagination\">\r\n        <li class=\"active\"><a href=\"\">1</a></li>\r\n        <li><a href=\"\">2</a></li>\r\n        <li><a href=\"\">3</a></li>\r\n        <li><a href=\"\">&raquo;</a></li>\r\n    </ul>\r\n</div><!--features_items-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
