#pragma checksum "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\MyView\xinchao1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d93e9eed21e05d2f4fa18d71e4f9da2d224e251"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.MyView_xinchao1), @"mvc.1.0.view", @"/MyView/xinchao1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d93e9eed21e05d2f4fa18d71e4f9da2d224e251", @"/MyView/xinchao1.cshtml")]
    public class MyView_xinchao1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\MyView\xinchao1.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card bg-primary text-white\">\r\n    <h1 class=\"card-header\">Xin chào ");
#nullable restore
#line 8 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\MyView\xinchao1.cshtml"
                                Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <div class=\"card-body\">\r\n        <p class=\"card-text\">\r\n            Bạn đang tìm hiểu về View (.cshtml) trong ASP.NET MVC\r\n        </p>\r\n    </div>\r\n</div>\r\n<hr>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Hieu Hieu\Desktop\AppMvcNet\AppMvcNet\MyView\xinchao1.cshtml"
Write(this.Path);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
