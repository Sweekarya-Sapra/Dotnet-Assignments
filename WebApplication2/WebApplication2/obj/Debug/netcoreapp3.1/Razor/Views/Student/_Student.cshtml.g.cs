#pragma checksum "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4232d44077717426a775d0a3803fca3ca8462f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student__Student), @"mvc.1.0.view", @"/Views/Student/_Student.cshtml")]
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
#line 1 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4232d44077717426a775d0a3803fca3ca8462f34", @"/Views/Student/_Student.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student__Student : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n    \n<table class=\"table\">\r\n  <thead>\r\n    <tr>\r\n      <th scope=\"col\">#</th>\r\n      <th scope=\"col\">First Name</th>\r\n      <th scope=\"col\">Last Name</th>\r\n      <th scope=\"col\">Email</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 14 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
   foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tr>\r\n      <th scope=\"row\"><a");
            BeginWriteAttribute("href", " href=\"", 312, "\"", 365, 2);
            WriteAttributeValue("", 319, "https://localhost:44375/Student/Index/", 319, 38, true);
#nullable restore
#line 16 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
WriteAttributeValue("", 357, item.Id, 357, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n      <td>");
#nullable restore
#line 17 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
     Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 18 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
     Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 19 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\sweek\source\repos\WebApplication2\WebApplication2\Views\Student\_Student.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
