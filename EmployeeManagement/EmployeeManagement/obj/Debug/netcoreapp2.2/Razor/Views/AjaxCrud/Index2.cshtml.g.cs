#pragma checksum "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c016c0b30fc827ab911c272f17f17f167770ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AjaxCrud_Index2), @"mvc.1.0.view", @"/Views/AjaxCrud/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AjaxCrud/Index2.cshtml", typeof(AspNetCore.Views_AjaxCrud_Index2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c016c0b30fc827ab911c272f17f17f167770ff", @"/Views/AjaxCrud/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0af6bde1461f59f01365565e6a88c1186882ebff", @"/Views/_ViewImports.cshtml")]
    public class Views_AjaxCrud_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreProject.Models.Classes.Player>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/CustomUi/jquery-ui.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("70"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/AppFile/Images/no.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("change_edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("AddProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("SubmitForm1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return AjaxPost(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery1/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jqueryui/jquery-ui.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_16 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_17 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(139, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(141, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45c016c0b30fc827ab911c272f17f17f167770ff10552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(200, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45c016c0b30fc827ab911c272f17f17f167770ff11805", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(274, 784, true);
            WriteLiteral(@"
<br />
<br />
<h2 style=""font-family:Algerian; text-align:center; color:orangered;"">Player Information (Jquery & Ajax)</h2>
<div class=""container"" style=""background-color:burlywood"">
    <a href=""#"" class=""btn btn-primary"" onclick=""AddNewPlayer(0)"">Add New Player</a>
    <br />
    <table class=""table table-striped"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Email</th>
                <th>Date Of Birth</th>
                <th>Phone</th>
                <th>Team</th>
                <th>Salary</th>
                <th>Image</th>
                <th>Action(Edit)</th>
                <th>Action(Details)</th>
                <th>Action(Delete)</th>
            </tr>

        </thead>
");
            EndContext();
#line 32 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
         foreach (var item in Model)
        {
            var photoPath = "~/Images/" + (item.ImageUrl ?? "no.png");

#line default
#line hidden
            BeginContext(1179, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1210, 13, false);
#line 36 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.PlayerID);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1247, 9, false);
#line 37 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1256, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1280, 10, false);
#line 38 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1290, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1314, 59, false);
#line 39 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(Convert.ToString(String.Format("{0:MM/dd/yyyy}", item.DoB)));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1397, 10, false);
#line 40 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1407, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1431, 9, false);
#line 41 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.Team);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1464, 11, false);
#line 42 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
           Write(item.Salary);

#line default
#line hidden
            EndContext();
            BeginContext(1475, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1498, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45c016c0b30fc827ab911c272f17f17f167770ff16851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#line 43 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
              WriteLiteral(photoPath);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 43 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1571, 85, true);
            WriteLiteral("</td>\r\n\r\n            <td><a href=\'#\' class=\'btn btn-warning glyphicon glyphicon-edit\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1656, "\'", 1692, 3);
            WriteAttributeValue("", 1666, "EditPlayer(", 1666, 11, true);
#line 45 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
WriteAttributeValue("", 1677, item.PlayerID, 1677, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1691, ")", 1691, 1, true);
            EndWriteAttribute();
            BeginContext(1693, 95, true);
            WriteLiteral(">Edit</a></td>\r\n            <td><a href=\'#\' class=\'btn btn-primary glyphicon glyphicon-th-list\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1788, "\'", 1827, 3);
            WriteAttributeValue("", 1798, "DetailsPlayer(", 1798, 14, true);
#line 46 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
WriteAttributeValue("", 1812, item.PlayerID, 1812, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1826, ")", 1826, 1, true);
            EndWriteAttribute();
            BeginContext(1828, 95, true);
            WriteLiteral(">Details</a></td>\r\n            <td><a href=\'#\' class=\'btn btn-danger glyphicon glyphicon-trash\'");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\'", 1923, "\'", 1961, 3);
            WriteAttributeValue("", 1933, "DeletePlayer(", 1933, 13, true);
#line 47 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
WriteAttributeValue("", 1946, item.PlayerID, 1946, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 1960, ")", 1960, 1, true);
            EndWriteAttribute();
            BeginContext(1962, 33, true);
            WriteLiteral(">Delete</a></td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "H:\PROJECT\Untitled folder\EmployeeManagement\EmployeeManagement\Views\AjaxCrud\Index2.cshtml"
        }

#line default
#line hidden
            BeginContext(2006, 385, true);
            WriteLiteral(@"

    </table>
    <div class=""modal fade"" id=""myModal"" style="" background-color: dimgrey"">
        <div class=""modal-dialog"">
            <div class=""modal-header"">
                <a href=""#"" class=""close"" data-dismiss=""modal"">&times;</a>
                <h4 id=""ModalTitle"" style=""color:white""></h4>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(2391, 1812, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c016c0b30fc827ab911c272f17f17f167770ff21787", async() => {
                BeginContext(2510, 1367, true);
                WriteLiteral(@"

                    <input type=""hidden"" id=""PlrId"" name=""PlayerID"" />
                    <label style=""color:chartreuse"">Name</label><br />
                    <input type=""text"" id=""Name"" name=""Name"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Email</label><br />
                    <input type=""email"" id=""email"" name=""email"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Date of Birth</label><br />
                    <input type=""datetime"" id=""dob"" name=""dob"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Phone</label><br />
                    <input type=""text"" id=""phone"" name=""phone"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Team</label><br />
                    <input type=""text"" id=""team"" name=""team"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Grade</label><br />
                    <select");
                WriteLiteral(@" class=""form-control"" id=""gradeDropdown"" name=""GradeId""></select> <br />

                    <label style=""color:chartreuse"">Salary</label><br />
                    <input type=""number"" id=""salary"" name=""salary"" class=""form-control"" /><br />

                    <label style=""color:chartreuse"">Image</label><br />
                    ");
                EndContext();
                BeginContext(3877, 91, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "45c016c0b30fc827ab911c272f17f17f167770ff23650", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3968, 228, true);
                WriteLiteral("\r\n                    <input type=\"file\" id=\"UploadImage\" name=\"UploadImage\" class=\"form-control changeImage\" /><br />\r\n                    <input type=\"submit\" value=\"Add Player\" class=\"btn btn-success\" />\r\n\r\n\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4203, 102, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div id=\"partialDiv\" style=\"display:none\">\r\n");
            EndContext();
            BeginContext(4350, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(4362, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c016c0b30fc827ab911c272f17f17f167770ff27328", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4409, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4411, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c016c0b30fc827ab911c272f17f17f167770ff28509", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4466, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4468, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c016c0b30fc827ab911c272f17f17f167770ff29690", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_16);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4539, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4541, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c016c0b30fc827ab911c272f17f17f167770ff30871", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_17);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4631, 3951, true);
            WriteLiteral(@"



<script>
    $(document).ready(function () {
        $.ajax({
            type: ""GET"",
            url: ""/AjaxCrud/GetCategories"",
            data: ""{}"",
            success: function (data) {
                var s = '<option value=""-1"">Select One</option>';
                for (var i = 0; i < data.length; i++) {
                    s += '<option value=""' + data[i].GradeId + '"">' + data[i].Name + '</option>';
                }
                $(""#gradeDropdown"").html(s);
            }
        });
    });

    $(document).ready(function () {
        $(""#dob"").datepicker({
            changeMonth: true, changeYear: true
        });
    })

    $(function () {
        $('.changeImage').change(function () {
            var input = this;
            if (input.files) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('.change_edit').attr('src', e.target.result);
                }
                reader.readAsDa");
            WriteLiteral(@"taURL(input.files[0])
            }

        })
    })

    function AjaxPost(formData) {
        var dropDownVal = $(""#gradeDropdown"").val();
        var gradeId = dropDownVal;
        //var categoryChoice = $('#gradeDropdown option:selected').val()
        formData.append('GradeId', gradeId);
        alert(formData)
        var ajaxConfig = {
            type: ""POST"",
            url: ""/AjaxCrud/SaveData"",
            data: new FormData(formData),
            success: function (result) {
                //alert(result);
                window.location.href = ""/AjaxCrud/Index"";

            }
        }
        if ($(formData).attr('enctype') == ""multipart/form-data"") {
            ajaxConfig[""contentType""] = false;
            ajaxConfig[""processData""] = false;
        }
        $.ajax(ajaxConfig);
        return false;
    }


    function AddNewPlayer(PlayerId) {
        //$(""#AddProduct"")[0].reset();
        $(""#PlrId"").val(0);
        $(""#ModalTitle"").html(""Add new playe");
            WriteLiteral(@"r"");
        $(""#myModal"").modal();
    }


    function EditPlayer(PlayerID) {
        var plId = PlayerID;

        $(""#PlrId"").val(plId);
        var url = ""/AjaxCrud/GetPlayersById?PlayerID="" + plId;
        $(""#ModalTitle"").html(""Update player Record"");
        $(""#myModal"").modal();
        $.ajax({
            type: ""GET"",
            url: url,
            success: function (data) {
                var obj = JSON.parse(data);
                $(""#PlrId"").val(obj.PlayerID);
                $(""#Name"").val(obj.Name);
                $(""#team"").val(obj.Team);
                $(""#email"").val(obj.Email);
                $(""#dob"").val(obj.DoB);

                $(""#phone"").val(obj.Phone);
                //$(""#gradeDropdown"").val(obj.GradeId);
                $(""#salary"").val(obj.Salary);
                $(""#image"").val(obj.ImageUrl);
            }
        })
    }


    function DeletePlayer(PlayerID) {
        var Id = PlayerID;
        $.ajax({
            url: ""/AjaxCrud/");
            WriteLiteral(@"deleteRecord?Id="" + Id,
            type: ""POST"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                alert(""deleted successfully"");
            },
            error: function () {
                alert(""deleted successfully"");
                location.reload();
            }
        })
    }
    function DetailsPlayer(PlayerID) {
        var plrId = PlayerID;
        $.ajax({
            url: ""/AjaxCrud/GetplayerDetails?PlayerId="" + plrId,
            type: ""GET"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                $(""#partialDiv"").show();
                $(""#partialDiv"").html(data);
            },
            error: function () {
                alert(""Error Occured"");
            }
        })
    }
</script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreProject.Models.Classes.Player>> Html { get; private set; }
    }
}
#pragma warning restore 1591