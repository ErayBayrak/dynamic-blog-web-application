#pragma checksum "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "918df7c21676d22ff34be69e2da03c9610c0c1c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryDashboard/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"918df7c21676d22ff34be69e2da03c9610c0c1c2", @"/Views/Shared/Components/CategoryDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Project Status</h4>
                <div class=""table-responsive"">
                    <table class=""table"">
                        <thead>
                            <tr>
                                <th> # </th>
                                <th> Kategori </th>
                                <th> Durum </th>
                                <th> ????lemler </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 18 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                             foreach (var x in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td> ");
#nullable restore
#line 21 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                    Write(x.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td> ");
#nullable restore
#line 22 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                    Write(x.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                    <td>\r\n");
#nullable restore
#line 24 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                         if (x.CategoryStatus == true)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-success\">");
#nullable restore
#line 25 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                                               Write(x.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>");
#nullable restore
#line 25 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                                                                         }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"btn btn-danger\">");
#nullable restore
#line 28 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                                                 Write(x.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </td>
                                    <td>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-gradient-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                        </div>
                                    </td>
                                </tr>
");
#nullable restore
#line 37 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryDashboard\Default.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
