#pragma checksum "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94ff27898778e1269260e71666772caabdc5fe0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PlayerDetailsPartial), @"mvc.1.0.view", @"/Views/Shared/_PlayerDetailsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PlayerDetailsPartial.cshtml", typeof(AspNetCore.Views_Shared__PlayerDetailsPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94ff27898778e1269260e71666772caabdc5fe0", @"/Views/Shared/_PlayerDetailsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af6bde1461f59f01365565e6a88c1186882ebff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PlayerDetailsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreProject.Models.ViewModes.PlayerListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
   
    var photoPath = "/Images/" + (Model.ImageUrl ?? "no.png");

#line default
#line hidden
            BeginContext(129, 152, true);
            WriteLiteral("<div>\r\n    <h4>Player Details</h4>\r\n    <br />\r\n    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <th>Player ID</th>\r\n            <td>");
            EndContext();
            BeginContext(282, 32, false);
#line 11 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.PlayerID));

#line default
#line hidden
            EndContext();
            BeginContext(314, 86, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Player Name</th>\r\n            <td>");
            EndContext();
            BeginContext(401, 28, false);
#line 15 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.Name));

#line default
#line hidden
            EndContext();
            BeginContext(429, 80, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Email</th>\r\n            <td>");
            EndContext();
            BeginContext(510, 29, false);
#line 19 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.Email));

#line default
#line hidden
            EndContext();
            BeginContext(539, 88, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Date of Birth</th>\r\n            <td>");
            EndContext();
            BeginContext(628, 27, false);
#line 23 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.DoB));

#line default
#line hidden
            EndContext();
            BeginContext(655, 80, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Phone</th>\r\n            <td>");
            EndContext();
            BeginContext(736, 29, false);
#line 27 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(765, 79, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Team</th>\r\n            <td>");
            EndContext();
            BeginContext(845, 28, false);
#line 31 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.Team));

#line default
#line hidden
            EndContext();
            BeginContext(873, 81, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Salary</th>\r\n            <td>");
            EndContext();
            BeginContext(955, 30, false);
#line 35 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
           Write(Html.DisplayFor(p => p.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(985, 84, true);
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th>Image</th>\r\n            <th><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1069, "\"", 1085, 1);
#line 39 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\Shared\_PlayerDetailsPartial.cshtml"
WriteAttributeValue("", 1075, photoPath, 1075, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1086, 72, true);
            WriteLiteral(" width=\"75\" height=\"80\" /></th>\r\n        </tr>\r\n\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProject.Models.ViewModes.PlayerListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
