#pragma checksum "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a4b9cc4843ce1aa34c8fca1c5ff76485868369f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_view), @"mvc.1.0.view", @"/Views/Home/view.cshtml")]
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
#line 1 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\_ViewImports.cshtml"
using hobbyHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\_ViewImports.cshtml"
using hobbyHub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a4b9cc4843ce1aa34c8fca1c5ff76485868369f", @"/Views/Home/view.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a39228bcfb1b138b4bd49da937afad1b678c55", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_view : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<hobbyHub.Models.Hobby>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Novice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Intermediate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Expert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
  
    ViewData["Title"] = Model.name;
    bool isHobby = false;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p class=\"display-2\">");
#nullable restore
#line 7 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
                Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<div class=\"container\">\r\n    <dt class=\"col-sm-3\">Description</dt>\r\n    <dd class=\"col-sm-9 ms-3\">");
#nullable restore
#line 10 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
                         Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    <div class=\"d-flex justify-content-between\">\r\n        <div>\r\n            <dt class=\"col-sm-3\">Enthusiasts</dt>\r\n");
#nullable restore
#line 14 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
             foreach (association item in Model.User_)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
                 if (item.User_id == ViewBag.user.id)
                {
                    { isHobby = true; }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"ms-3\">");
#nullable restore
#line 20 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
                           Write(item.User.username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" is a ");
#nullable restore
#line 20 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
                                                    Write(item.level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 21 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div>\r\n\r\n");
#nullable restore
#line 25 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
             if (!isHobby)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4b9cc4843ce1aa34c8fca1c5ff76485868369f7879", async() => {
                WriteLiteral("\r\n                    <p>Become an Enthusiast!</p>\r\n                    <select name=\"level\"");
                BeginWriteAttribute("id", " id=\"", 915, "\"", 920, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-select mb-3\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4b9cc4843ce1aa34c8fca1c5ff76485868369f8433", async() => {
                    WriteLiteral("Novice");
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
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4b9cc4843ce1aa34c8fca1c5ff76485868369f9680", async() => {
                    WriteLiteral("Intermediate");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a4b9cc4843ce1aa34c8fca1c5ff76485868369f10933", async() => {
                    WriteLiteral("Expert");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                    <div class=\"d-grid mb-3\">\r\n                        <input type=\"submit\" class=\"btn btn-outline-dark\" value=\"Add to hobbies\">\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 780, "/add/", 780, 5, true);
#nullable restore
#line 27 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
AddHtmlAttributeValue("", 785, Model.id, 785, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Nathan Foster\Desktop\Productive Files\Coding Dojo\cSharpFund\beltTest\hobbyHub\Views\Home\view.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<hobbyHub.Models.Hobby> Html { get; private set; }
    }
}
#pragma warning restore 1591