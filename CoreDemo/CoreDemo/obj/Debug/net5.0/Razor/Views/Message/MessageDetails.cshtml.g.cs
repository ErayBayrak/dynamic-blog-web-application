#pragma checksum "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dda69d611bdfd961044e873c1c791fa15d74dbb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_MessageDetails), @"mvc.1.0.view", @"/Views/Message/MessageDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dda69d611bdfd961044e873c1c791fa15d74dbb8", @"/Views/Message/MessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_MessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Message2>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
  
    ViewData["Title"] = "MessageDetails";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mesaj Detay Sayfası</h1>\r\n<br />\r\n\r\n    ");
#nullable restore
#line 10 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("ID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 11 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.MessageID, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 13 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextBoxFor(x => x.Subject, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    ");
#nullable restore
#line 16 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.Label("Gönderen"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 17 "C:\Users\Eray Monster\source\repos\CoreDemo\CoreDemo\Views\Message\MessageDetails.cshtml"
Write(Html.TextAreaFor(x => x.MessageDetails, 15, 3, new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n   \r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Message2> Html { get; private set; }
    }
}
#pragma warning restore 1591
