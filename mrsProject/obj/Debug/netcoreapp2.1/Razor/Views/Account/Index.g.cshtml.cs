#pragma checksum "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "540b198eb1daa102799e2ac2f2f5109ec102ef77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"540b198eb1daa102799e2ac2f2f5109ec102ef77", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mrsProject.Models.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
  
    ViewBag.Title = "Manage";

#line default
#line hidden
            BeginContext(81, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(88, 13, false);
#line 7 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(101, 131, true);
            WriteLiteral(".</h2>\r\n\r\n<div>\r\n    <h4>Hello Welcome</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>First Name:</dt>\r\n        <dd>");
            EndContext();
            BeginContext(233, 15, false);
#line 14 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(248, 48, true);
            WriteLiteral("</dd>\r\n        <dt>Last Name:</dt>\r\n        <dd>");
            EndContext();
            BeginContext(297, 14, false);
#line 16 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
       Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(311, 44, true);
            WriteLiteral("</dd>\r\n        <dt>Email:</dt>\r\n        <dd>");
            EndContext();
            BeginContext(356, 11, false);
#line 18 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(367, 46, true);
            WriteLiteral("</dd>\r\n        <dt>Address:</dt>\r\n        <dd>");
            EndContext();
            BeginContext(414, 13, false);
#line 20 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
       Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(427, 51, true);
            WriteLiteral("</dd>\r\n        <dt>Phone Number:</dt>\r\n        <dd>");
            EndContext();
            BeginContext(479, 17, false);
#line 22 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
       Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(496, 66, true);
            WriteLiteral("</dd>\r\n\r\n        <dt>Password:</dt>\r\n        <dd>\r\n            [\r\n");
            EndContext();
#line 27 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
             if (Model.HasPassword)
            {
                

#line default
#line hidden
            BeginContext(631, 57, false);
#line 29 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
           Write(Html.ActionLink("Change your password", "ChangePassword"));

#line default
#line hidden
            EndContext();
#line 29 "C:\Users\reddy\Documents\MIS 333K HW\UpdatedProject\mrsProject\Views\Account\Index.cshtml"
                                                                          
            }

#line default
#line hidden
            BeginContext(705, 66, true);
            WriteLiteral("            ]\r\n\r\n        </dd>\r\n    </dl>\r\n\r\n   \r\n</div>\r\n<hr />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mrsProject.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
