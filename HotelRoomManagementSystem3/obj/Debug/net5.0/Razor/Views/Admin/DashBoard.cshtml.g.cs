#pragma checksum "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "521422f4b4766ec398efaf4e1a0624cbfaafe206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DashBoard), @"mvc.1.0.view", @"/Views/Admin/DashBoard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521422f4b4766ec398efaf4e1a0624cbfaafe206", @"/Views/Admin/DashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64adfaff053719173d97f0313c33a31b8e428cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Reservation1>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admin/DashBoard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("f8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", new global::Microsoft.AspNetCore.Html.HtmlString("red"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
  
    ViewData["Title"] = "DsplayReserv";
    Layout = "~/views/shared/_mylayout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
 if (@ViewBag.Session == "2")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Guest List  </h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "521422f4b4766ec398efaf4e1a0624cbfaafe2065772", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "521422f4b4766ec398efaf4e1a0624cbfaafe2066038", async() => {
                    WriteLiteral("\r\n            <input class=\"form-control me-sm-2\" type=\"text\" placeholder=\"Search\" id=\"search\" name=\"search\">\r\n            <button class=\"btn btn-secondary my-2 my-sm-0\" type=\"submit\">Search</button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

        <table class=""table"">
            <tr>
                <th>Reservation Id</th>
                <th>Room Number</th>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Phone Number</th>
                <th>Address</th>
                <th>Check In</th>
                <th>Check Out</th>
                <th>Room Type</th>
                <th>Payment Amount</th>
            </tr>
");
#nullable restore
#line 30 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td colspan=\"3\" style=\"color:red\">\r\n                        No Match Any Document\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 44 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.Resid);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.FcilentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.LcilentName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.CilentPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.CilentAdress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 50 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.CheckIn);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 51 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.CheckOut);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.RoomType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 53 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                       Write(item.PaymentAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                        <td>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 1893, "\"", 1931, 2);
                WriteAttributeValue("", 1900, "/reservation/delete/", 1900, 20, true);
#nullable restore
#line 56 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 1920, item.Resid, 1920, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" btn btn-outline-info\">UNBOOK</a>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 60 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
#line 73 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
                  Write(TempData["successMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\";\r\n            if (msg)\r\n                opensuc(msg);\r\n\r\n        });\r\n        </script>\r\n    ");
            }
            );
#nullable restore
#line 79 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
     
}
else if (@ViewBag.session == "3")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h1>Illegal access To the Admin\'s DashBoard is forbidden!!!\'</h1>\r\n    <h2>Please LogIn First!!!\'</h2>\r\n    <input type=\"button\" value=\"LOGIN\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2753, "\"", 2824, 2);
#nullable restore
#line 86 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
WriteAttributeValue("", 2763, "window.location.href='"+ Url.Action("login","admin")+"'", 2763, 60, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2823, ";", 2823, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
#nullable restore
#line 88 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Admin\DashBoard.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Reservation1>> Html { get; private set; }
    }
}
#pragma warning restore 1591