#pragma checksum "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4e125c12c9570e15828d14c2fb59d50a7365b69342af95cd592d33eeb1f76a91"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using DemoPL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using DemoPL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using Demo.DAL.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using Demo.BLL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4e125c12c9570e15828d14c2fb59d50a7365b69342af95cd592d33eeb1f76a91", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a374d0b6d2c67ca1c98bdf4dd1d45f4eed068d35466b59127516c4ddd096b9f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "All Users"; // Dictionary Composite From (Key, Value)
                                 // ViewBag.Title = "Index"; // Dynamic Object Composite From Properties


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Users </h1>\r\n<br />\r\n<br />\r\n\r\n\r\n\r\n<div class=\"row justify-content-center align-items-center mt-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e125c12c9570e15828d14c2fb59d50a7365b69342af95cd592d33eeb1f76a915837", async() => {
                WriteLiteral(@"
        <div class=""col-8"">
            <input type=""text"" class=""form-control"" name=""email"" id=""searchInp"" placeholder=""Search By Email"" />
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 26 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"mt-4 table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n\r\n                <th>");
#nullable restore
#line 32 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 37 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
               Write(Html.DisplayNameFor(U => U.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>           \r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 44 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 47 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(M=>user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(M=>user.FName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(M=>user.LName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(M=>user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(Html.DisplayFor(M=>user.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
                   Write(string.Join( " ",user.Roles));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   \r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4e125c12c9570e15828d14c2fb59d50a7365b69342af95cd592d33eeb1f76a9112052", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 55 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = user.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 58 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 63 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-4 alert alert-warning\">\r\n        <h3>There is No Users :(</h3>\r\n    </div>\r\n");
#nullable restore
#line 70 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Users\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
