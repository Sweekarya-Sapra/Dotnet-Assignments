#pragma checksum "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a190e333b0ce8d07e4c76aeb7228a37f944e2ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowDetail), @"mvc.1.0.view", @"/Views/Employee/ShowDetail.cshtml")]
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
#line 1 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\_ViewImports.cshtml"
using NS.EMS.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\_ViewImports.cshtml"
using NS.EMS.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a190e333b0ce8d07e4c76aeb7228a37f944e2ff", @"/Views/Employee/ShowDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0e976826eb89a4a7920fcfdbfcd2cb9045aceb8", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ShowDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NS.EMS.Data.Entities.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
  
    ViewData["Title"] = "ShowDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <table class=""table"">
      <thead>

        <tr>
          <th scope=""col"">Id</th>
          <th scope=""col"">Name</th>
          <th scope=""col"">Email</th>
          <th scope=""col"">Mobile</th>
          <th scope=""col"">Department</th>
         
         
          <th scope=""col"">Update</th>
           <th scope=""col"">Delete</th>
        </tr>
      </thead>
      <tbody>
");
#nullable restore
#line 29 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
            foreach (var item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n               \r\n                <td>");
#nullable restore
#line 33 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(item.Eid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(item.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                \r\n              \r\n                <td>");
#nullable restore
#line 40 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(Html.ActionLink("Update","Update", new { id=@item.Eid }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 41 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
               Write(Html.ActionLink("Delete","Delete", new { id=@item.Eid}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n               \r\n           </tr>\r\n");
#nullable restore
#line 44 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("       \r\n        \r\n      \r\n  </tbody>\r\n\r\n</table>\r\n<hr />\r\n ");
#nullable restore
#line 52 "C:\Users\sweek\source\repos\EMS\NS.EMS.WEB\Views\Employee\ShowDetail.cshtml"
Write(Html.ActionLink("Add new employee", "EmployeeDetail"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NS.EMS.Data.Entities.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
