#pragma checksum "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca3cbfe7de519520748b86c9fa97214d7226173e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(razor_gpa_web_app.Pages.GetAllGPAs.Pages_GetAllGPAs_GetSGPAs), @"mvc.1.0.razor-page", @"/Pages/GetAllGPAs/GetSGPAs.cshtml")]
namespace razor_gpa_web_app.Pages.GetAllGPAs
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
#line 1 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\_ViewImports.cshtml"
using razor_gpa_web_app;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3cbfe7de519520748b86c9fa97214d7226173e", @"/Pages/GetAllGPAs/GetSGPAs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17031c90b79308887feacee90b1c1969c1b51d5c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_GetAllGPAs_GetSGPAs : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:250px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "IntakeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 5 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>SGPA</h1>\n\n<br />\n\n\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3cbfe7de519520748b86c9fa97214d7226173e5452", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3cbfe7de519520748b86c9fa97214d7226173e5716", async() => {
                    WriteLiteral("\n            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca3cbfe7de519520748b86c9fa97214d7226173e5994", async() => {
                        WriteLiteral("-- Select Intake Number--");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 15 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(Model.Intake,"IntakeNumber","IntakeNumber"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <br />\n       <input class=\"btn btn-primary\" type=\"submit\" value=\"Search\" />\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<br />\n\n\n<div class=\".container\">\n    <table class=\"table table-striped\">\n        <thead class=\"thead-dark\">\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 31 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].RegNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 34 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 37 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    Intake No\n                </th>\n\n                <th>\n                    ");
#nullable restore
#line 44 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 47 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemTwo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 50 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemThree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 53 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemFour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 56 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemFive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 59 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemSix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 62 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemSeven));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 65 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemEight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 68 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemNine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 71 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
               Write(Html.DisplayNameFor(model => model.StudentGPAList[0].SGPAValueForSemTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 76 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
             foreach (var item in Model.StudentGPAList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>\n        ");
#nullable restore
#line 80 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.RegNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 83 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 86 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 89 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(item.IntakeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 92 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemOne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 95 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemTwo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 98 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemThree));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 101 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemFour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 104 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemFive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 107 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemSix));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 110 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemSeven));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 113 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemEight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 116 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemNine));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 119 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
   Write(Html.DisplayFor(modelItem => item.SGPAValueForSemTen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n</tr>");
#nullable restore
#line 122 "F:\4th Semester\GPA-Group06-Calculation-Managment-System\razor-gpa-web-app-dev\razor-gpa-web-app\Pages\GetAllGPAs\GetSGPAs.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<razor_gpa_web_app.Pages.GetAllGPAs.GetSGPAs> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<razor_gpa_web_app.Pages.GetAllGPAs.GetSGPAs> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<razor_gpa_web_app.Pages.GetAllGPAs.GetSGPAs>)PageContext?.ViewData;
        public razor_gpa_web_app.Pages.GetAllGPAs.GetSGPAs Model => ViewData.Model;
    }
}
#pragma warning restore 1591
