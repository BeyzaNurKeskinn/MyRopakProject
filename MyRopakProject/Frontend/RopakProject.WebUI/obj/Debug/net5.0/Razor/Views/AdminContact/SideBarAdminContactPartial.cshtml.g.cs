#pragma checksum "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\SideBarAdminContactPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c8b1f64cec93d6c9538dd30958c92dd057195e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContact_SideBarAdminContactPartial), @"mvc.1.0.view", @"/Views/AdminContact/SideBarAdminContactPartial.cshtml")]
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
#line 1 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ServiceDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.RegisterDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.LoginDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.AboutDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ProjectDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.TestimonialDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.StaffDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.ContactDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Dtos.SendMessageDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c8b1f64cec93d6c9538dd30958c92dd057195e4", @"/Views/AdminContact/SideBarAdminContactPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f875e8253286147d13c18298611ea4d30e7c5819", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminContact_SideBarAdminContactPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"mail-list mt-4\">\r\n    <a href=\"/AdminContact/Inbox/\" class=\"list-group-item border-0 text-primary p-r-0\"><i class=\"fa fa-inbox font-18 align-middle mr-2\"></i> <b>Gelen Kutusu</b> <span class=\"badge badge-primary badge-sm float-right m-t-5\">");
#nullable restore
#line 2 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\SideBarAdminContactPartial.cshtml"
                                                                                                                                                                                                                         Write(ViewBag.contactCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> </a>\r\n\r\n    <a href=\"/AdminContact/Sendbox/\" class=\"list-group-item border-0 text-info p-r-0\"><i class=\"fa fa-paper-plane font-18 align-middle mr-2\"></i><b>Giden Kutusu</b><span class=\"badge badge-info badge-sm float-right m-t-5\">");
#nullable restore
#line 4 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminContact\SideBarAdminContactPartial.cshtml"
                                                                                                                                                                                                                         Write(ViewBag.sendMessageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a>

    <a href=""#"" class=""list-group-item border-0 text-danger p-r-0""><i class=""fa fa-star-o font-18 align-middle mr-2""></i><b>Önemli </b><span class=""badge badge-danger badge-sm float-right m-t-5"">50</span> </a>

    <a href=""#"" class=""list-group-item border-0 text-warning p-r-0""><i class=""mdi mdi-file-document-box font-18 align-middle mr-2""></i><b>Taslaklar</b> <span class=""badge badge-warning badge-sm float-right m-t-5"">18</span></a>

    <a href=""#"" class=""list-group-item border-0 text-dark p-r-0""><i class=""fa fa-trash font-18 align-middle mr-2""></i><b>Çöp Kutusu</b><span class=""badge badge-dark badge-sm float-right m-t-5"">36</span></a>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
