#pragma checksum "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Account\CheckYourInbox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d53b6e65f23631d6ad942b2a4766e43986bd7d9cea469d669f5db909df3203c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckYourInbox), @"mvc.1.0.view", @"/Views/Account/CheckYourInbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d53b6e65f23631d6ad942b2a4766e43986bd7d9cea469d669f5db909df3203c8", @"/Views/Account/CheckYourInbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a374d0b6d2c67ca1c98bdf4dd1d45f4eed068d35466b59127516c4ddd096b9f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_CheckYourInbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Route\Back-End\06 MVC\Session 06\Demo\G03 Demo Solution\DemoPL\Views\Account\CheckYourInbox.cshtml"
  
    ViewData["Title"] = "CheckYourInbox";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-agileinfo"">
            <div class=""agileits-top"">
                <div class=""body"">

                    <div>
                    <p>Password Reset Link has been sent to your email. Please check your inbox:) </p>
                </div>
                <a href=""https://mail.google.com/mail/u/0/#inbox"">Your Inbox</a>
                </div>

            </div>
        </div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
