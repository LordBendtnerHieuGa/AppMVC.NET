#pragma checksum "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f53f92a2b294a3c44e1dfc9c2b0050b378442f27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PagingXTL), @"mvc.1.0.view", @"/Views/Shared/_PagingXTL.cshtml")]
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
#line 1 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\_ViewImports.cshtml"
using AppMvcNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\_ViewImports.cshtml"
using AppMvcNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f53f92a2b294a3c44e1dfc9c2b0050b378442f27", @"/Views/Shared/_PagingXTL.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0eb278c38dcbece03ace66ee73931443661a05", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PagingXTL : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppMvcNet.Models.PagingModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
  
    int currentPage  = Model.currentpage;
    int countPages   = Model.countpages;
    var generateUrl  = Model.generateUrl;


    
    if (currentPage > countPages) 
      currentPage = countPages;

    if (countPages <= 1) return;
    

    int? preview = null;
    int? next = null;

    if (currentPage > 1)
        preview = currentPage - 1;

    if (currentPage < countPages)
        next = currentPage + 1;

    // Các trang hiện thị trong điều hướng
    List<int> pagesRanges = new List<int>();    

        
    int delta      = 5;             // Số trang mở rộng về mỗi bên trang hiện tại     
    int remain     = delta * 2;     // Số trang hai bên trang hiện tại

    pagesRanges.Add(currentPage);
    // Các trang phát triển về hai bên trang hiện tại
    for (int i = 1; i <= delta; i++)
    {
        if (currentPage + i  <= countPages) {
            pagesRanges.Add(currentPage + i); 
            remain --;
        }
               
        if (currentPage - i >= 1) {
            pagesRanges.Insert(0, currentPage - i);
            remain --;
        }
            
    }    
    // Xử lý thêm vào các trang cho đủ remain 
    //(xảy ra ở đầu mút của khoảng trang không đủ trang chèn  vào)
    if (remain > 0) {
        if (pagesRanges[0] == 1) {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.Last() + 1 <= countPages) {
                    pagesRanges.Add(pagesRanges.Last() + 1);
                }
            }
        }
        else {
            for (int i = 1; i <= remain; i++)
            {
                if (pagesRanges.First() - 1 > 1) {
                    pagesRanges.Insert(0, pagesRanges.First() - 1);
                }
            }
        }
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<ul class=\"pagination\">\n    <!-- Previous page link -->\n");
#nullable restore
#line 80 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
     if (preview != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2130, "\"", 2158, 1);
#nullable restore
#line 83 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2137, generateUrl(preview), 2137, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang trước</a>\n        </li>\n");
#nullable restore
#line 85 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang trước</a>\n        </li>\n");
#nullable restore
#line 91 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("      \n    <!-- Numbered page links -->\n");
#nullable restore
#line 94 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
     foreach (var pageitem in pagesRanges)
    {
        if (pageitem != currentPage) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item\">\n                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2563, "\"", 2592, 1);
#nullable restore
#line 98 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 2570, generateUrl(pageitem), 2570, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    ");
#nullable restore
#line 99 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
               Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </a>\n            </li>\n");
#nullable restore
#line 102 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
        }   
        else 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"page-item active\" aria-current=\"page\">\n                <a class=\"page-link\" href=\"#\">");
#nullable restore
#line 106 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
                                         Write(pageitem);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span class=\"sr-only\">(current)</span></a>\n            </li>\n");
#nullable restore
#line 108 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    <!-- Next page link -->\n");
#nullable restore
#line 113 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
     if (next != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item\">\n            <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3018, "\"", 3043, 1);
#nullable restore
#line 116 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
WriteAttributeValue("", 3025, generateUrl(next), 3025, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Trang sau</a>\n        </li>\n");
#nullable restore
#line 118 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
    }
    else 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"page-item disabled\">\n            <a class=\"page-link\" href=\"#\" tabindex=\"-1\" aria-disabled=\"true\">Trang sau</a>\n        </li>\n");
#nullable restore
#line 124 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\Views\Shared\_PagingXTL.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppMvcNet.Models.PagingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
