#pragma checksum "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb94c9714d522e004d43b5e199cf9cc0b4e47a3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_AddToOrder), @"mvc.1.0.view", @"/Views/Orders/AddToOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/AddToOrder.cshtml", typeof(AspNetCore.Views_Orders_AddToOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb94c9714d522e004d43b5e199cf9cc0b4e47a3a", @"/Views/Orders/AddToOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_AddToOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<mrsProject.Models.OrderDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
  
    ViewData["Title"] = "AddToOrder";

#line default
#line hidden
            BeginContext(86, 27, true);
            WriteLiteral("\r\n<h2>Add To Order</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(148, 23, false);
#line 11 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(175, 47, true);
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <hr />\r\n    ");
            EndContext();
            BeginContext(223, 64, false);
#line 15 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(287, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(294, 44, false);
#line 16 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
Write(Html.HiddenFor(model => model.Order.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(338, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(345, 42, false);
#line 17 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
Write(Html.HiddenFor(model => model.Book.BookID));

#line default
#line hidden
            EndContext();
            BeginContext(387, 40, true);
            WriteLiteral("\r\n    <div class=\"form=group\">\r\n        ");
            EndContext();
            BeginContext(428, 102, false);
#line 19 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
   Write(Html.LabelFor(model => model.OrderQuantity, htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(530, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(577, 102, false);
#line 21 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
       Write(Html.EditorFor(model => model.OrderQuantity, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(679, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(694, 91, false);
#line 22 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
       Write(Html.ValidationMessageFor(model => model.OrderQuantity, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 233, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Add Book to Cart\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
#line 32 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
}

#line default
#line hidden
            BeginContext(1021, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1035, 40, false);
#line 35 "C:\Users\reddy\Documents\MIS 333K HW\FinalKP\mrsProject\Views\Orders\AddToOrder.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<mrsProject.Models.OrderDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
