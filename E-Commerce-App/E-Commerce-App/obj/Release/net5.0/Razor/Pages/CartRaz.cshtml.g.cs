#pragma checksum "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54a89f68c2501ce5ea4da5a095de43b160a97f24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CartRaz), @"mvc.1.0.razor-page", @"/Pages/CartRaz.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a89f68c2501ce5ea4da5a095de43b160a97f24", @"/Pages/CartRaz.cshtml")]
    #nullable restore
    public class Pages_CartRaz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
 if(Model.products.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>There is no products...</p>\r\n");
#nullable restore
#line 8 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
}
else
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
     foreach (var item in Model.products)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<ul>\r\n\t\t\t<li>\r\n\t\t\t\t");
#nullable restore
#line 15 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</li>\r\n\t\t</ul>\r\n");
#nullable restore
#line 18 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
	}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "I:\ECOMMERCE\E-Commerce-App\E-Commerce-App\E-Commerce-App\Pages\CartRaz.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Commerce_App.Pages.CartRazModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Commerce_App.Pages.CartRazModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<E_Commerce_App.Pages.CartRazModel>)PageContext?.ViewData;
        public E_Commerce_App.Pages.CartRazModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
