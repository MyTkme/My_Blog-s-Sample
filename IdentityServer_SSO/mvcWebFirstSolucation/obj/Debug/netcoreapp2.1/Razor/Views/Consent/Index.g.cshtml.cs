#pragma checksum "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8201f0af848e50b7dd938875d2dbf41dc40d30bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consent_Index), @"mvc.1.0.view", @"/Views/Consent/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consent/Index.cshtml", typeof(AspNetCore.Views_Consent_Index))]
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
#line 1 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\_ViewImports.cshtml"
using mvcWebFirstSolucation;

#line default
#line hidden
#line 2 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
using mvcWebFirstSolucation.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8201f0af848e50b7dd938875d2dbf41dc40d30bb", @"/Views/Consent/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aee6b771d7600d4c0eed3e2e851432f5ea0d5ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_Consent_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsentVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 21, true);
            WriteLiteral("<p>Consent Page</p>\r\n");
            EndContext();
            BeginContext(77, 60, true);
            WriteLiteral("<div class=\"row page-header\">\r\n    <div class=\"col-sm-10\">\r\n");
            EndContext();
#line 6 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
         if (!string.IsNullOrWhiteSpace(Model.Logo))
        {

#line default
#line hidden
            BeginContext(202, 39, true);
            WriteLiteral("            <div>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 241, "\"", 258, 1);
#line 9 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
WriteAttributeValue("", 247, Model.Logo, 247, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(259, 26, true);
            WriteLiteral(" /> \r\n            </div>\r\n");
            EndContext();
#line 11 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(296, 26, true);
            WriteLiteral("        <h1>\r\n            ");
            EndContext();
            BeginContext(323, 16, false);
#line 13 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
       Write(Model.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(339, 132, true);
            WriteLiteral("\r\n            <small>欢迎来到第三方授权</small>\r\n        </h1>\r\n\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-8\">\r\n        ");
            EndContext();
            BeginContext(471, 1809, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1561ba182cbb4f84aa320d488f28ee80", async() => {
                BeginContext(496, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(510, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d47bbe0636fa4583a289b6373693c5b6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 22 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ReturnUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(553, 240, true);
                WriteLiteral("\r\n            <div class=\"panel\">\r\n                <div class=\"panel-heading\">\r\n                    <span class=\"glyphicon glyphicon-tasks\"></span>\r\n                    用户信息\r\n                </div>\r\n                <ul class=\"list-group\">\r\n");
                EndContext();
#line 29 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                     foreach (var item in Model.IdentityScopes)
                    {
                        

#line default
#line hidden
                BeginContext(906, 36, false);
#line 31 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                   Write(Html.Partial("_ScopeListItem", item));

#line default
#line hidden
                EndContext();
#line 31 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                                                             ;
                    }

#line default
#line hidden
                BeginContext(968, 301, true);
                WriteLiteral(@"                </ul>
            </div>
            <div class=""panel"">
                    <div class=""panel-heading"">
                        <span class=""glyphicon glyphicon-tasks""></span>
                        应用权限
                    </div>
                    <ul class=""list-group"">
");
                EndContext();
#line 41 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                         foreach (var item in Model.ResourceScopes)
                        {
                            

#line default
#line hidden
                BeginContext(1394, 36, false);
#line 43 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                       Write(Html.Partial("_ScopeListItem", item));

#line default
#line hidden
                EndContext();
#line 43 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                                                                 ;
                        }

#line default
#line hidden
                BeginContext(1460, 117, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n\r\n            <div>\r\n                <label>\r\n                    ");
                EndContext();
                BeginContext(1577, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56a723d6cff04d55ba0a793a5f3c2f69", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 50 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RemeberConsent);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1627, 272, true);
                WriteLiteral(@"
                    <strong>记住我的选择</strong>
                </label>
            </div>
            <div>
                <button value=""yes"" class=""btn btn-primary"" name=""button""  autofocus>同意</button>
                <button value=""no"" name=""button"">取消</button>
");
                EndContext();
#line 57 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                 if (!string.IsNullOrEmpty(Model.ClientUrl))
                {

#line default
#line hidden
                BeginContext(1980, 22, true);
                WriteLiteral("                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2002, "\"", 2025, 1);
#line 59 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
WriteAttributeValue("", 2009, Model.ClientUrl, 2009, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2026, 147, true);
                WriteLiteral(" class=\"pull-right btn btn-default\">\r\n                        <span class=\"glyphicon glyphicon-info-sign\"></span>\r\n                        <strong>");
                EndContext();
                BeginContext(2174, 15, false);
#line 61 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                           Write(Model.ClientUrl);

#line default
#line hidden
                EndContext();
                BeginContext(2189, 37, true);
                WriteLiteral("</strong>\r\n                    </a>\r\n");
                EndContext();
#line 63 "C:\Users\94709\Desktop\mvcWebFirstSolucation\mvcWebFirstSolucation\Views\Consent\Index.cshtml"
                }

#line default
#line hidden
                BeginContext(2245, 28, true);
                WriteLiteral("            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2280, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
