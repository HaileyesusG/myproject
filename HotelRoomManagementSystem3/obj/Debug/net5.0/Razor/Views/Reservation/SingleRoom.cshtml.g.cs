#pragma checksum "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f5aa75524f216e3ece5b50e9f85bd7d1e77ceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_SingleRoom), @"mvc.1.0.view", @"/Views/Reservation/SingleRoom.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f5aa75524f216e3ece5b50e9f85bd7d1e77ceb", @"/Views/Reservation/SingleRoom.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64adfaff053719173d97f0313c33a31b8e428cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_SingleRoom : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("f3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
  
    ViewData["Title"] = "SingleRoom";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f5aa75524f216e3ece5b50e9f85bd7d1e77ceb3837", async() => {
                WriteLiteral(@"
    <center><h1>SINGLE ROOM LIST</h1></center>
   
    <table class=""table"">
        <tr>
            <th>RoomId</th>
            <th>Room Phone</th>
            <th>Room Status</th>
            <th>Room type</th>
            <th>Payment Amount</th>
            <th>Book Room</th>
        </tr>
");
#nullable restore
#line 20 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
               Write(item.RoomId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
               Write(item.RoomPhone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
               Write(item.RoomStatus);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
               Write(item.Roomtype);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
               Write(item.PaymentAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 722, "\"", 761, 2);
                WriteAttributeValue("", 729, "/reservation/create/", 729, 20, true);
#nullable restore
#line 31 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
WriteAttributeValue("", 749, item.RoomId, 749, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\" btn btn-outline-info\"");
                BeginWriteAttribute("style", " style=\'", 792, "\'", 890, 3);
                WriteAttributeValue("", 800, "display:", 800, 8, true);
                WriteAttributeValue("", 808, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 31 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"
                                                                                                               if (item.RoomStatus == "busy"||item.RoomStatus == "BUSY") { Write("none"); } 

#line default
#line hidden
#nullable disable
                    PopWriter();
                }
                ), 808, 81, false);
                WriteAttributeValue(" ", 889, "", 890, 1, true);
                EndWriteAttribute();
                WriteLiteral(">BOOK</a>\r\n                </td>\r\n\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\haile\source\repos\HotelRoomManagementSystem3\HotelRoomManagementSystem3\Views\Reservation\SingleRoom.cshtml"


        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
