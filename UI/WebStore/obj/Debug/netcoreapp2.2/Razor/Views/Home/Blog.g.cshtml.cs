#pragma checksum "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Home\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416c2e48d7f0f57a45735a12df7c3280eb6cdf73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Blog), @"mvc.1.0.view", @"/Views/Home/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Blog.cshtml", typeof(AspNetCore.Views_Home_Blog))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416c2e48d7f0f57a45735a12df7c3280eb6cdf73", @"/Views/Home/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0da7d44e6fc850ed9be8ca8602fae6055b5539b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Blog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/blog-one.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/blog-two.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/blog/blog-three.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Home\Blog.cshtml"
  
    ViewData["Title"] = "Блог";

#line default
#line hidden
            BeginContext(42, 8037, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-3"">
        <div class=""left-sidebar"">
            <h2>Category</h2>
            <div class=""panel-group category-products"" id=""accordian"">
                <!--category-productsr-->
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
                                <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                Sportswear
                            </a>
                        </h4>
                    </div>
                    <div id=""sportswear"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <ul>
                                <li><a href="""">Nike </a></li>
                                <li><a href="""">Under Armour </a></li>
               ");
            WriteLiteral(@"                 <li><a href="""">Adidas </a></li>
                                <li><a href="""">Puma</a></li>
                                <li><a href="""">ASICS </a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#mens"">
                                <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
                                Mens
                            </a>
                        </h4>
                    </div>
                    <div id=""mens"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <ul>
                                <li><a href="""">Fendi</a></li>
                                <li><a h");
            WriteLiteral(@"ref="""">Guess</a></li>
                                <li><a href="""">Valentino</a></li>
                                <li><a href="""">Dior</a></li>
                                <li><a href="""">Versace</a></li>
                                <li><a href="""">Armani</a></li>
                                <li><a href="""">Prada</a></li>
                                <li><a href="""">Dolce and Gabbana</a></li>
                                <li><a href="""">Chanel</a></li>
                                <li><a href="""">Gucci</a></li>
                            </ul>
                        </div>
                    </div>
                </div>

                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">
                            <a data-toggle=""collapse"" data-parent=""#accordian"" href=""#womens"">
                                <span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
             ");
            WriteLiteral(@"                   Womens
                            </a>
                        </h4>
                    </div>
                    <div id=""womens"" class=""panel-collapse collapse"">
                        <div class=""panel-body"">
                            <ul>
                                <li><a href="""">Fendi</a></li>
                                <li><a href="""">Guess</a></li>
                                <li><a href="""">Valentino</a></li>
                                <li><a href="""">Dior</a></li>
                                <li><a href="""">Versace</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Kids</a></h4>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""");
            WriteLiteral(@"panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Fashion</a></h4>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Households</a></h4>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Interiors</a></h4>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Clothing</a></h4>
                    </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Bags</a></h4>
      ");
            WriteLiteral(@"              </div>
                </div>
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title""><a href=""#"">Shoes</a></h4>
                    </div>
                </div>
            </div><!--/category-products-->

            <div class=""brands_products"">
                <!--brands_products-->
                <h2>Brands</h2>
                <div class=""brands-name"">
                    <ul class=""nav nav-pills nav-stacked"">
                        <li><a href=""""> <span class=""pull-right"">(50)</span>Acne</a></li>
                        <li><a href=""""> <span class=""pull-right"">(56)</span>Grüne Erde</a></li>
                        <li><a href=""""> <span class=""pull-right"">(27)</span>Albiro</a></li>
                        <li><a href=""""> <span class=""pull-right"">(32)</span>Ronhill</a></li>
                        <li><a href=""""> <span class=""pull-right"">(5)</span>Oddmolly</a></li>
               ");
            WriteLiteral(@"         <li><a href=""""> <span class=""pull-right"">(9)</span>Boudestijn</a></li>
                        <li><a href=""""> <span class=""pull-right"">(4)</span>Rösch creative culture</a></li>
                    </ul>
                </div>
            </div><!--/brands_products-->

            <div class=""price-range"">
                <!--price-range-->
                <h2>Price Range</h2>
                <div class=""well"">
                    <input type=""text"" class=""span2"" value="""" data-slider-min=""0"" data-slider-max=""600"" data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
                    <b>$ 0</b> <b class=""pull-right"">$ 600</b>
                </div>
            </div><!--/price-range-->

            <div class=""shipping text-center"">
                <!--shipping-->
                <img src=""images/home/shipping.jpg"" alt="""" />
            </div><!--/shipping-->
        </div>
    </div>
    <div class=""col-sm-9"">
        <div class=""blog-post-area"">
            <h2");
            WriteLiteral(@" class=""title text-center"">Latest From our Blog</h2>
            <div class=""single-blog-post"">
                <h3>Girls Pink T Shirt arrived in store</h3>
                <div class=""post-meta"">
                    <ul>
                        <li><i class=""fa fa-user""></i> Mac Doe</li>
                        <li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
                        <li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
                    </ul>
                    <span>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                    </span>
                </div>
                <a href="""">
                    ");
            EndContext();
            BeginContext(8079, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "416c2e48d7f0f57a45735a12df7c3280eb6cdf7313526", async() => {
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
            EndContext();
            BeginContext(8124, 1285, true);
            WriteLiteral(@"
                </a>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
                <a class=""btn btn-primary"" href="""">Read More</a>
            </div>
            <div class=""single-blog-post"">
                <h3>Girls Pink T Shirt arrived in store</h3>
                <div class=""post-meta"">
                    <ul>
                        <li><i class=""fa fa-user""></i> Mac Doe</li>
                        <li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
                        <li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
                    </ul>
                    <span>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
    ");
            WriteLiteral(@"                    <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                    </span>
                </div>
                <a href="""">
                    ");
            EndContext();
            BeginContext(9409, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "416c2e48d7f0f57a45735a12df7c3280eb6cdf7316124", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9454, 1285, true);
            WriteLiteral(@"
                </a>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
                <a class=""btn btn-primary"" href="""">Read More</a>
            </div>
            <div class=""single-blog-post"">
                <h3>Girls Pink T Shirt arrived in store</h3>
                <div class=""post-meta"">
                    <ul>
                        <li><i class=""fa fa-user""></i> Mac Doe</li>
                        <li><i class=""fa fa-clock-o""></i> 1:33 pm</li>
                        <li><i class=""fa fa-calendar""></i> DEC 5, 2013</li>
                    </ul>
                    <span>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
    ");
            WriteLiteral(@"                    <i class=""fa fa-star""></i>
                        <i class=""fa fa-star""></i>
                        <i class=""fa fa-star-half-o""></i>
                    </span>
                </div>
                <a href="""">
                    ");
            EndContext();
            BeginContext(10739, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "416c2e48d7f0f57a45735a12df7c3280eb6cdf7318723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10786, 873, true);
            WriteLiteral(@"
                </a>
                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.</p>
                <a class=""btn btn-primary"" href="""">Read More</a>
            </div>
            <div class=""pagination-area"">
                <ul class=""pagination"">
                    <li><a href="""" class=""active"">1</a></li>
                    <li><a href="""">2</a></li>
                    <li><a href="""">3</a></li>
                    <li><a href=""""><i class=""fa fa-angle-double-right""></i></a></li>
                </ul>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
