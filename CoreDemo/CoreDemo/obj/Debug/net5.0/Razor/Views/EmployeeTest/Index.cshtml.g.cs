#pragma checksum "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc765f91675200d1f700daa7a346e0f9540516b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#line 1 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
using CoreDemo.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc765f91675200d1f700daa7a346e0f9540516b1", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Class1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>AD</th>\r\n        <th>SİL</th>\r\n        <th>DÜZENLE</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
           Write(x.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
           Write(x.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 436, "\"", 485, 2);
            WriteAttributeValue("", 443, "/EmployeeTest/DeleteEmployee/", 443, 29, true);
#nullable restore
#line 20 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 472, x.EmployeeID, 472, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 542, "\"", 589, 2);
            WriteAttributeValue("", 549, "/EmployeeTest/EditEmployee/", 549, 27, true);
#nullable restore
#line 21 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 576, x.EmployeeID, 576, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">GÜNCELLE</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\EmployeeTest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/EmployeeTest/AddEmployee/\" class=\"btn btn-success\">YENİ ÇALIŞAN EKLE</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591