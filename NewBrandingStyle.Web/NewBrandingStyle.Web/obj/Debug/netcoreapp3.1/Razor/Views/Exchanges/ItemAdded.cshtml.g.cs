#pragma checksum "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Exchanges\ItemAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2668934b4f45ebcbaf6b76b71ece43487863211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exchanges_ItemAdded), @"mvc.1.0.view", @"/Views/Exchanges/ItemAdded.cshtml")]
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
#line 1 "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\_ViewImports.cshtml"
using NewBrandingStyle.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2668934b4f45ebcbaf6b76b71ece43487863211", @"/Views/Exchanges/ItemAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f0e01d906794e7d20db596d96f08e9d5ca555d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exchanges_ItemAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyAddedViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Your item was successfully added!</h1>\r\n\r\n<h5>Some stats:</h5>\r\n\r\n<div>Chars in Name: ");
#nullable restore
#line 7 "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Exchanges\ItemAdded.cshtml"
               Write(Model.NumberOfCharsInName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Chars in Description: ");
#nullable restore
#line 8 "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Exchanges\ItemAdded.cshtml"
                      Write(Model.NumberOfCharsInDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>Is the item currently hidden: ");
#nullable restore
#line 9 "C:\Users\anna.mika\Desktop\WSEI\Programowanie w środowisku ASP.NET\NewBrandingStyle\NewBrandingStyle.Web\NewBrandingStyle.Web\Views\Exchanges\ItemAdded.cshtml"
                               Write(Model.IsHidden ? "yes" : "no");

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyAddedViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591