#pragma checksum "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a978e77d820887c33a8c1cd4b495654bcb88283"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUsers_Index), @"mvc.1.0.view", @"/Views/AdminUsers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a978e77d820887c33a8c1cd4b495654bcb88283", @"/Views/AdminUsers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f875e8253286147d13c18298611ea4d30e7c5819", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUsers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelProject.EntityLayer.Concrete.AppUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <table class=""table table-xs mb-0"">
                            <thead>
                                <tr>
                                    <th>#</th>
                                    <th>Ad Soyad</th>
                                    <th>Şehir</th>
                                    <th>Durum</th>
                                    
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 18 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                                 foreach(var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td><img");
            BeginWriteAttribute("src", " src=\"", 797, "\"", 817, 1);
#nullable restore
#line 20 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
WriteAttributeValue("", 803, item.ImageUrl, 803, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\" rounded-circle mr-3\"");
            BeginWriteAttribute("alt", " alt=\"", 847, "\"", 853, 0);
            EndWriteAttribute();
            WriteLiteral("></td>\r\n                                    <td>");
#nullable restore
#line 21 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                                              Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 22 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td><i class=\"fa fa-circle-o text-success  mr-2\"></i> Aktif</td>\r\n                                </tr>\r\n");
#nullable restore
#line 25 "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminUsers\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             </tbody>\r\n                        </table>\r\n                        <br />\r\n                        <a href=\"/Register/Index/\" class=\"btn btn-primary\">Yeni Kullanıcı Kaydı</a>\r\n            \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelProject.EntityLayer.Concrete.AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
