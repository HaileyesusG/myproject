#pragma checksum "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daecf923790ea450e47f22fde287561f0cce2637"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_Delete), @"mvc.1.0.view", @"/Views/Reservation/Delete.cshtml")]
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
#line 1 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\_ViewImports.cshtml"
using HotelRoomManagementSystem3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\_ViewImports.cshtml"
using HotelRoomManagementSystem3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"daecf923790ea450e47f22fde287561f0cce2637", @"/Views/Reservation/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64adfaff053719173d97f0313c33a31b8e428cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reservation1>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
   ViewData["Title"] = "Delete"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete Product</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daecf923790ea450e47f22fde287561f0cce26373919", async() => {
                WriteLiteral("\n    <table class=\"table\">\n        <tr>\n            <td>\n                <label for=\"ProductName\">Guest First Name</label>\n            </td>\n            <td>\n\n                ");
#nullable restore
#line 13 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
           Write(Model.FcilentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td>\n                <label for=\"Price\">Guest Last Name</label>\n            </td>\n            <td>\n                ");
#nullable restore
#line 21 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
           Write(Model.LcilentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td>\n                <label for=\"Price\">Address</label>\n            </td>\n            <td>\n                ");
#nullable restore
#line 29 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
           Write(Model.CilentAdress);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n        <tr>\n            <td>\n                <label for=\"Price\">Room Number</label>\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
           Write(Model.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </td>\n        </tr>\n\n    </table>\n\n    <div>Are you sure to delete this product?</div>\n    <button type=\"submit\" class=\"btn btn-danger\">Delete</button>\n    <a class=\"btn btn-warning\" href=\"/admin/dashboard\">Cancel</a>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 94, "/Reservation/Delete/", 94, 20, true);
#nullable restore
#line 5 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
AddHtmlAttributeValue("", 114, Model.Resid, 114, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        function opensuc(strmsg) {
            var mydiv = document.getElementById(""modalSuccessAlert"");
            mydiv.innerHTML = strmsg;
            $('#modalSuccess').modal('show');
        }
        $(document).ready(function () {

            var msg = """);
#nullable restore
#line 56 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\Delete.cshtml"
                  Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\n            if (msg)\n                opensuc(msg);\n\n        });\n    </script>\n");
            }
            );
            WriteLiteral("\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reservation1> Html { get; private set; }
    }
}
#pragma warning restore 1591
