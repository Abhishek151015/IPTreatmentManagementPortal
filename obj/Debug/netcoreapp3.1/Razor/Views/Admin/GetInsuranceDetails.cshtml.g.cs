#pragma checksum "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f3c42c1c125bbd59566dd00121700cc47448dc9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetInsuranceDetails), @"mvc.1.0.view", @"/Views/Admin/GetInsuranceDetails.cshtml")]
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
#line 1 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\_ViewImports.cshtml"
using IPTreatmentManagementPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\_ViewImports.cshtml"
using IPTreatmentManagementPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f3c42c1c125bbd59566dd00121700cc47448dc9", @"/Views/Admin/GetInsuranceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b45695c2b551b4b7ecadc40d566286b56b55f7ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetInsuranceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IPTreatmentManagementPortal.Models.InsurerDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetRecords", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
  
    ViewData["Title"] = "GetInsuranceDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Insurance Details</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.InsurerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.InsurerPackageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.InsuranceAmountLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DisbursementDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 28 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 31 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.InsurerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.InsurerPackageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.InsuranceAmountLimit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.DisbursementDuration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n               \n                ");
#nullable restore
#line 44 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
           Write(Html.ActionLink("InitiateClaim", "InitiateClaim", new {  insurer=item.InsurerName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 47 "F:\IPTreatmentMFRP\IPTreatmentManagementPortal-master\Views\Admin\GetInsuranceDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f3c42c1c125bbd59566dd00121700cc47448dc97491", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IPTreatmentManagementPortal.Models.InsurerDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591