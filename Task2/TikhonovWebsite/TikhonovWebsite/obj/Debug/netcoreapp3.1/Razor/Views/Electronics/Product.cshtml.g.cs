#pragma checksum "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cae91618b49092923082c2e2ae5e92a3532efbf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Electronics_Product), @"mvc.1.0.view", @"/Views/Electronics/Product.cshtml")]
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
#line 1 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\_ViewImports.cshtml"
using TikhonovWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\_ViewImports.cshtml"
using TikhonovWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
using TikhonovWebsite.DBContext;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae91618b49092923082c2e2ae5e92a3532efbf4", @"/Views/Electronics/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a7c3717b40d24e15a310c2d7415afc5b38eb942", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Electronics_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
  
    Layout = "Master.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n<h1>");
#nullable restore
#line 6 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
Write(ViewBag.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>         \r\n    <p>");
#nullable restore
#line 7 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
  Write(ViewBag.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 164, "\"", 203, 3);
            WriteAttributeValue("", 170, "/images/", 170, 8, true);
#nullable restore
#line 8 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
WriteAttributeValue("", 178, ViewBag.Product.Id, 178, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 199, ".jpg", 199, 4, true);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 204, "\"", 232, 1);
#nullable restore
#line 8 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
WriteAttributeValue("", 210, ViewBag.Product.Title, 210, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"160\"/>\r\n    <p>");
#nullable restore
#line 9 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
  Write(ViewBag.Product.Specifications);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 10 "C:\Users\zenit\Desktop\Учеба\6 семестр\Практика\LogstreamTestingTikhonov\Task2\TikhonovWebsite\TikhonovWebsite\Views\Electronics\Product.cshtml"
  Write(ViewBag.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
