#pragma checksum "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_Leftsidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f479aebb78883bf8a7f662c247fd3f68bdbdb7a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partial__Leftsidebar), @"mvc.1.0.view", @"/Views/Shared/Partial/_Leftsidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Partial/_Leftsidebar.cshtml", typeof(AspNetCore.Views_Shared_Partial__Leftsidebar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f479aebb78883bf8a7f662c247fd3f68bdbdb7a0", @"/Views/Shared/Partial/_Leftsidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0da7d44e6fc850ed9be8ca8602fae6055b5539b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partial__Leftsidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 34, true);
            WriteLiteral("<div class=\"left-sidebar\">\r\n\r\n    ");
            EndContext();
            BeginContext(35, 38, false);
#line 3 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_Leftsidebar.cshtml"
Write(await Component.InvokeAsync("Section"));

#line default
#line hidden
            EndContext();
            BeginContext(73, 8, true);
            WriteLiteral("\r\n\r\n    ");
            EndContext();
            BeginContext(82, 37, false);
#line 5 "K:\DATA\Мои документы\Учёба\МИП\C#\GeekBrains\ASP.NET 1 курс\WebStore\UI\WebStore\Views\Shared\Partial\_Leftsidebar.cshtml"
Write(await Component.InvokeAsync("Brands"));

#line default
#line hidden
            EndContext();
            BeginContext(119, 577, true);
            WriteLiteral(@";

    <div class=""price-range"">
        <!--price-range-->
        <h2>Price Range</h2>
        <div class=""well text-center"">
            <input type=""text"" class=""span2"" value="""" data-slider-min=""0"" data-slider-max=""600"" data-slider-step=""5"" data-slider-value=""[250,450]"" id=""sl2""><br />
            <b class=""pull-left"">$ 0</b> <b class=""pull-right"">$ 600</b>
        </div>
    </div><!--/price-range-->

    <div class=""shipping text-center"">
        <!--shipping-->
        <img src=""images/home/shipping.jpg"" alt="""" />
    </div><!--/shipping-->

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
