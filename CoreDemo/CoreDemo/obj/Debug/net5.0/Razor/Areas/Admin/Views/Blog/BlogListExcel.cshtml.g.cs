#pragma checksum "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Blog\BlogListExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57649ef8e447fcff19b52c23b308117e333a1a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogListExcel), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogListExcel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57649ef8e447fcff19b52c23b308117e333a1a6", @"/Areas/Admin/Views/Blog/BlogListExcel.cshtml")]
    public class Areas_Admin_Views_Blog_BlogListExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Blog\BlogListExcel.cshtml"
  
    ViewData["Title"] = "BlogListExcel";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Excel ile Veri Seti Oluşturma Sayfası</h1>
<button class=""btn btn-primary"" onclick=""DownloadExcelBlogList()"">Excel Listesini İndir</button>
<script>
    function DownloadExcelBlogList() {
        window.open(""ExportStaticExcelBlogList"")
    }
</script>");
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
