#pragma checksum "C:\Users\beyza\source\repos\MyUdemyProject\Frontend\HotelProject.WebUI\Views\AdminLayout\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5e5a942a740c28edae099accd97d68235d1938"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout_SidebarPartial), @"mvc.1.0.view", @"/Views/AdminLayout/SidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5e5a942a740c28edae099accd97d68235d1938", @"/Views/AdminLayout/SidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f875e8253286147d13c18298611ea4d30e7c5819", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminLayout_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""nk-sidebar"">
    <div class=""nk-nav-scroll"">
      
        <ul class=""metismenu"" id=""menu"">
          
            <li>
                <a href=""/Default/Index/"" aria-expanded=""false"">
                    <i class=""icon-plane menu-icon""></i><span class=""nav-text"">Siteye Git</span>
                </a>
            </li>
            <li>
                <a href=""/Dashboard/Index/"" aria-expanded=""false"">
                    <i class=""icon-magic-wand menu-icon""></i><span class=""nav-text"">Dashboard</span>
                </a>
            </li>
            <li>
                <a href=""/Staff/Index/"" aria-expanded=""false"">
                    <i class=""icon-notebook menu-icon""></i><span class=""nav-text"">Personeller</span>
                </a>
            </li>
            <li>
                <a href=""/Testimonial/Index/"" aria-expanded=""false"">
                    <i class=""icon-lock menu-icon""></i><span class=""nav-text"">Referanslar</span>
                </a>
            </li>");
            WriteLiteral(@"
            <li>
                <a href=""/Service/Index/"" aria-expanded=""false"">
                    <i class=""icon-clock menu-icon""></i><span class=""nav-text"">Hizmetler</span>
                </a>
            </li>
            <li>
                <a href=""/AdminAbout/Index/"" aria-expanded=""false"">
                    <i class=""icon-info menu-icon""></i><span class=""nav-text"">Hakkımızda</span>
                </a>
            </li>
            <li>
                <a href=""/AdminProject/Index/"" aria-expanded=""false"">
                    <i class=""icon-settings menu-icon""></i><span class=""nav-text"">Projeler</span>
                </a>
            </li>
            <li>
                <a href=""/AdminContact/Inbox/"" aria-expanded=""false"">
                    <i class=""icon-envelope menu-icon""></i><span class=""nav-text"">Mesajlar</span>
                </a>
            </li>
            <li>
                <a href=""/AdminMail/Index/"" aria-expanded=""false"">
                    <i class=""ic");
            WriteLiteral(@"on-paper-clip menu-icon""></i><span class=""nav-text"">Mail İşlemleri</span>
                </a>
            </li>
            <li>
                <a href=""/AdminImageFile/Index/"" aria-expanded=""false"">
                    <i class=""icon-energy menu-icon""></i><span class=""nav-text"">Resim İşlemleri</span>
                </a>
            </li>
            <li>
                <a href=""/AdminFile/Index/"" aria-expanded=""false"">
                    <i class=""icon-film menu-icon""></i><span class=""nav-text"">Dosya İşlemleri</span>
                </a>
            </li>
            <li>
                <a href=""/AdminUsers/Index/"" aria-expanded=""false"">
                    <i class=""icon-user-follow menu-icon""></i><span class=""nav-text"">Kullanıcılar</span>
                </a>
            </li> 
            <li>
                <a href=""/Settings/Index/"" aria-expanded=""false"">
                    <i class=""icon-settings menu-icon""></i><span class=""nav-text"">Ayarlar</span>
                </a>
   ");
            WriteLiteral(@"         </li>
            <li>
                <a href=""/Login/Index/"" aria-expanded=""false"">
                    <i class=""icon-close menu-icon""></i><span class=""nav-text"">Çıkış Yap</span>
                </a>
            </li>
           
        </ul>
    </div>
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
