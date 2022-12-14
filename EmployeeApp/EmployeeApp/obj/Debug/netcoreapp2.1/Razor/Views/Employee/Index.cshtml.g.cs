#pragma checksum "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657ab6dfa86ec7d2f60b0a0a6b1938bba97d2032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp;

#line default
#line hidden
#line 2 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\_ViewImports.cshtml"
using EmployeeApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657ab6dfa86ec7d2f60b0a0a6b1938bba97d2032", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31a5f17362e1f1a59d64e80cf6fa78e508f49ea0", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeApp.Models.EmployeeModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(92, 26, true);
            WriteLiteral("\n<h2>Employee List</h2>\n\n\n");
            EndContext();
#line 10 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
 using (Html.BeginForm("Index", "Employee"))
{

#line default
#line hidden
            BeginContext(165, 322, true);
            WriteLiteral(@"    <div>
        <div class=""row"">
            <div class=""form-group col-lg-6"">
                <input type=""text"" class=""form-control"" name=""Id"" id=""txtName"" placeholder=""Insert Employee ID"" />
                <button class=""btn btn-success"" type=""submit"">Get Employees</button>
                <p class=""text-warning"">");
            EndContext();
            BeginContext(488, 15, false);
#line 17 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                                   Write(ViewBag.Warning);

#line default
#line hidden
            EndContext();
            BeginContext(503, 50, true);
            WriteLiteral("</p>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 21 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
}

#line default
#line hidden
            BeginContext(555, 138, true);
            WriteLiteral("\n\n\n<table class=\"table table-striped table-bordered table-hover\">\n    <thead class=\"thead-dark\">\n        <tr>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(694, 38, false);
#line 28 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(732, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(767, 40, false);
#line 29 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(807, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(842, 52, false);
#line 30 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.ContractTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(894, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(929, 42, false);
#line 31 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleId));

#line default
#line hidden
            EndContext();
            BeginContext(971, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1006, 44, false);
#line 32 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(1050, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1085, 51, false);
#line 33 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.RoleDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 34, true);
            WriteLiteral("</th>\n            <th scope=\"col\">");
            EndContext();
            BeginContext(1171, 47, false);
#line 34 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.AnualSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 33, true);
            WriteLiteral("</th>\n        </tr>\n    </thead>\n");
            EndContext();
#line 37 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(1291, 21, true);
            WriteLiteral("    <tr>\n        <td>");
            EndContext();
            BeginContext(1313, 7, false);
#line 41 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1320, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1339, 9, false);
#line 42 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1367, 21, false);
#line 43 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.ContractTypeName);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1407, 11, false);
#line 44 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.RoleId);

#line default
#line hidden
            EndContext();
            BeginContext(1418, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1437, 13, false);
#line 45 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(1450, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(1469, 20, false);
#line 46 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
       Write(item.RoleDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 39, true);
            WriteLiteral("</td>\n        <td class=\"text-success\">");
            EndContext();
            BeginContext(1529, 41, false);
#line 47 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
                            Write(string.Format("{0:C}", @item.AnualSalary));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 16, true);
            WriteLiteral("</td>\n    </tr>\n");
            EndContext();
#line 49 "C:\Proyectos\EmployeeApplication-master\EmployeeApp\EmployeeApp\Views\Employee\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1592, 9, true);
            WriteLiteral("</table>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeApp.Models.EmployeeModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
