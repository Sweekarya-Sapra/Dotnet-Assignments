#pragma checksum "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\Employee\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f820257e61affe4b88900df4d15af5cc353ae9f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_EmployeeList), @"mvc.1.0.view", @"/Views/Employee/EmployeeList.cshtml")]
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
#line 1 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f820257e61affe4b88900df4d15af5cc353ae9f8", @"/Views/Employee/EmployeeList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_EmployeeList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <h1>Employee List:</h1>\r\n</div>\r\n<hr/>\r\n<br/>\r\n<br/>\r\n<div>\r\n");
#nullable restore
#line 14 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\Employee\EmployeeList.cshtml"
 foreach (var item in Model.Employees)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div class=\"list-group\">\r\n  <a");
            BeginWriteAttribute("href", " href=\"", 302, "\"", 358, 2);
            WriteAttributeValue("", 309, "https://localhost:44397/Employee/index/", 309, 39, true);
#nullable restore
#line 17 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\Employee\EmployeeList.cshtml"
WriteAttributeValue("", 348, item.Name, 348, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"list-group-item list-group-item-action\">");
#nullable restore
#line 17 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\Employee\EmployeeList.cshtml"
                                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n</div>   \r\n");
#nullable restore
#line 19 "C:\Users\sweek\source\repos\WebApplication4\WebApplication4\Views\Employee\EmployeeList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
