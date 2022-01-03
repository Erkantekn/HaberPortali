#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f9ed4dbfb5b625ad171b013ef5929203d5a212"
// <auto-generated/>
#pragma warning disable 1591
namespace NewsPortal.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\_Imports.razor"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
    public partial class AdminLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "app");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main-wrapper main-wrapper-1");
            __builder.AddMarkupContent(5, "\n        <div class=\"navbar-bg\"></div>\n\n\n        ");
            __builder.AddMarkupContent(6, @"<nav class=""navbar navbar-expand-lg main-navbar"">
            <form class=""form-inline mr-auto"">
                <ul class=""navbar-nav mr-3"">
                    <li><a href=""javascript:;"" data-toggle=""search"" class=""nav-link nav-link-lg d-sm-none""><i class=""fas fa-search""></i></a></li>
                </ul>

            </form>
            <ul class=""navbar-nav navbar-right"">


                <li class=""dropdown"">
                    <a href=""javascript:;"" data-toggle=""dropdown"" class=""nav-link dropdown-toggle nav-link-lg nav-link-user"">
                        <img alt=""image"" src=""/assets/admin/img/avatar/avatar-1.png"" class=""rounded-circle mr-1"">
                        <div class=""d-sm-none d-lg-inline-block"">Admin</div>
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <a href=""/Account/Logout"" class=""dropdown-item has-icon text-danger"">
                            <i class=""fas fa-sign-out-alt""></i> Çıkış Yap
                        </a>
                    </div>
                </li>
            </ul>
        </nav>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main-sidebar sidebar-style-2");
            __builder.AddAttribute(9, "tabindex", "1");
            __builder.AddAttribute(10, "style", "overflow: hidden; outline: none;");
            __builder.AddMarkupContent(11, "\n            ");
            __builder.OpenElement(12, "aside");
            __builder.AddAttribute(13, "id", "sidebar-wrapper");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.AddMarkupContent(15, "<div class=\"sidebar-brand\">\n                    <a href=\"/Admin\">Erkan Tekin</a>\n                </div>\n                ");
            __builder.AddMarkupContent(16, "<div class=\"sidebar-brand sidebar-brand-sm\">\n                    <a href=\"/Admin\">ET</a>\n                </div>\n                ");
            __builder.OpenElement(17, "ul");
            __builder.AddAttribute(18, "class", "sidebar-menu");
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.AddMarkupContent(20, "<li class=\"menu-header\">İstatistikler</li>\n                    ");
            __builder.OpenElement(21, "li");
            __builder.AddAttribute(22, "class", 
#nullable restore
#line 43 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor"
                                GetActive("/admin")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(24);
            __builder.AddAttribute(25, "class", "nav-link");
            __builder.AddAttribute(26, "href", "/admin");
            __builder.AddAttribute(27, "data-toggle", "tooltip");
            __builder.AddAttribute(28, "data-original-title", "İstatistikler");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<i class=\"fas fa-fire\"></i> ");
                __builder2.AddMarkupContent(31, "<span>İstatistikler</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n                    ");
            __builder.AddMarkupContent(34, "<li class=\"menu-header\">Veri</li>\n\n                    ");
            __builder.OpenElement(35, "li");
            __builder.AddAttribute(36, "class", 
#nullable restore
#line 48 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor"
                                GetActive("/admin/news")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(37, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "nav-link");
            __builder.AddAttribute(40, "href", "/admin/news");
            __builder.AddAttribute(41, "data-toggle", "tooltip");
            __builder.AddAttribute(42, "data-original-title", "Haberler");
            __builder.AddAttribute(43, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(44, "<i class=\"far fa-newspaper\"></i> ");
                __builder2.AddMarkupContent(45, "<span>Haberler</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.OpenElement(48, "li");
            __builder.AddAttribute(49, "class", 
#nullable restore
#line 51 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor"
                                GetActive("/admin/categories")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "nav-link");
            __builder.AddAttribute(53, "href", "/admin/categories");
            __builder.AddAttribute(54, "data-toggle", "tooltip");
            __builder.AddAttribute(55, "data-original-title", "Kategoriler");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "<i class=\"far fa-circle\"></i> ");
                __builder2.AddMarkupContent(58, "<span>Kategoriler</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n                  \n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\n\n        \n        ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "main-content");
            __builder.AddAttribute(66, "style", "min-height: 842px;");
            __builder.AddMarkupContent(67, "\n            ");
            __builder.OpenElement(68, "section");
            __builder.AddAttribute(69, "class", "section");
            __builder.AddMarkupContent(70, "\n                ");
            __builder.AddContent(71, 
#nullable restore
#line 65 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(72, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n              \n\n                ");
            __builder.AddMarkupContent(75, @"<footer class=""main-footer"">
                    <div class=""footer-left"">
                        Copyright © 2021 <div class=""bullet""></div> 182119007 Erkan Tekin - 182119008  Onur Şahin
                    </div>
                    <div class=""footer-right"">

                    </div>
                </footer>

        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\AdminLayout.razor"
      
    [Inject]
    NavigationManager NavigationManager { get; set; }
    protected override void OnInitialized() => NavigationManager.LocationChanged += (s, e) => StateHasChanged();



    string GetActive(string href) {
        if (href.ToLower() == "/admin" && NavigationManager.Uri.ToLower() == NavigationManager.BaseUri.ToLower() + "admin")
            return "active";
        else if (href.ToLower() != "/admin" && NavigationManager.Uri.Contains(href))
            return "active";
        return "";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
