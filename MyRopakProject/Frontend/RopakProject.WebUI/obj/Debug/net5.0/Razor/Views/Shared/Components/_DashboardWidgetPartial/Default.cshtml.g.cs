#pragma checksum "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59b3875536bdf115cd438a43056a3c2abfc6a1cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__DashboardWidgetPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_DashboardWidgetPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b3875536bdf115cd438a43056a3c2abfc6a1cc", @"/Views/Shared/Components/_DashboardWidgetPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f875e8253286147d13c18298611ea4d30e7c5819", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__DashboardWidgetPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-3 col-sm-6"">
        <div class=""card gradient-1"">
            <div class=""card-body"">
                <h3 class=""card-title text-white"">Personel Sayısı</h3>
                <div class=""d-inline-block"">
                    <h2 class=""text-white"">");
#nullable restore
#line 7 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                      Write(ViewBag.v);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p class=\"text-white mb-0\">");
#nullable restore
#line 8 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                          Write(DateTime.Now.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 8 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <span class=""float-right display-5 opacity-5""><i class=""fa fa-users ""></i></span>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-sm-6"">
        <div class=""card gradient-2"">
            <div class=""card-body"">
                <h3 class=""card-title text-white"">Çalışan Memnuniyeti</h3>
                <div class=""d-inline-block"">
                    <h2 class=""text-white"">99%</h2>
                    <p class=""text-white mb-0"">");
#nullable restore
#line 20 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                          Write(DateTime.Now.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <span class=""float-right display-5 opacity-5""><i class=""fa ti-face-smile""></i></span>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-sm-6"">
        <div class=""card gradient-3"">
            <div class=""card-body"">
                <h3 class=""card-title text-white"">Aylık Ürün Satışı</h3>
                <div class=""d-inline-block"">
                    <h2 class=""text-white"">37</h2>
                    <p class=""text-white mb-0"">");
#nullable restore
#line 32 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                          Write(DateTime.Now.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 32 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <span class=""float-right display-5 opacity-5""><i class=""fa fa-shopping-cart""></i></span>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-sm-6"">
        <div class=""card gradient-4"">
            <div class=""card-body"">
                <h3 class=""card-title text-white"">Müşteri Memnuniyeti</h3>
                <div class=""d-inline-block"">
                    <h2 class=""text-white"">99%</h2>
                    <p class=""text-white mb-0"">");
#nullable restore
#line 44 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                          Write(DateTime.Now.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 44 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_DashboardWidgetPartial\Default.cshtml"
                                                                          Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <span class=\"float-right display-5 opacity-5\"><i class=\"fa fa-heart\"></i></span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
