#pragma checksum "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a42a800a8e3f1b530a780816d7c591a63435105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Delete), @"mvc.1.0.view", @"/Views/Categories/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categories/Delete.cshtml", typeof(AspNetCore.Views_Categories_Delete))]
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
#line 1 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models;

#line default
#line hidden
#line 2 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using EmployeeManagement.Models.ViewModels;

#line default
#line hidden
#line 3 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a42a800a8e3f1b530a780816d7c591a63435105", @"/Views/Categories/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af6bde1461f59f01365565e6a88c1186882ebff", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreProject.Models.Classes.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
  
    ViewBag.Title = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Category</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(301, 48, false);
#line 16 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(349, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(395, 44, false);
#line 20 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(439, 32, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n\r\n");
            EndContext();
#line 25 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(518, 23, false);
#line 27 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(545, 135, true);
            WriteLiteral("        <div class=\"form-actions no-color\">\r\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n            ");
            EndContext();
            BeginContext(681, 40, false);
#line 31 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(721, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 33 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Categories\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(746, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject.Models.Classes.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
