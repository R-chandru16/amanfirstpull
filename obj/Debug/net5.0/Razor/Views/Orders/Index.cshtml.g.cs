#pragma checksum "D:\amanpull1stcommit\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11674ed97370319825e22ef9e20d41b154e64e41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "D:\amanpull1stcommit\Views\_ViewImports.cshtml"
using PizzaHut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\amanpull1stcommit\Views\_ViewImports.cshtml"
using PizzaHut.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11674ed97370319825e22ef9e20d41b154e64e41", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8efdecd17e5559cbb270cc9907425448905b2398", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
  
    var Orders = (List<Orders>)ViewData["Orders"];
    var Pizza = (List<Pizza>)ViewData["Pizza"];
    var count = ViewData["count"];
    var sum = ViewData["sum"];



#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
Write(TempData.Peek("Address"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n<p>\r\n    \r\n");
#nullable restore
#line 15 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
     foreach (var item in Orders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>        \r\n                ");
#nullable restore
#line 18 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
           Write(item.Order_ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </P>\r\n");
#nullable restore
#line 20 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>\r\n");
#nullable restore
#line 23 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
     foreach(var item in Pizza)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n                ");
#nullable restore
#line 25 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                ");
#nullable restore
#line 26 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n             </p>\r\n");
#nullable restore
#line 29 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    ");
#nullable restore
#line 31 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 32 "D:\amanpull1stcommit\Views\Orders\Index.cshtml"
Write(sum);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n \r\n </p>\r\n</p>");
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