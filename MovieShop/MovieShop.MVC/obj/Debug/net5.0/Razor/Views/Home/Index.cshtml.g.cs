#pragma checksum "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b20ace8f03e21e61b1cffbdd8da5c8340636d55"
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
#line 1 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\_ViewImports.cshtml"
using MovieShop.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b20ace8f03e21e61b1cffbdd8da5c8340636d55", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed27a90769d57c4cf1e99ddf07e56b08d479e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationCore.Models.Response.MovieResponseModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 9 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
Write(ViewData["PageTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
                      Write(ViewBag.TotalMovies);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
 foreach (var movie in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>\r\n            ");
#nullable restore
#line 17 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
       Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            ");
#nullable restore
#line 20 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li>\r\n            ");
#nullable restore
#line 23 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"
       Write(movie.Budget);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
#nullable restore
#line 26 "C:\Users\Lianjie\Desktop\Antra\.Net\MovieShop\MovieShop.MVC\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationCore.Models.Response.MovieResponseModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
