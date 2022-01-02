#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86c3785facfeaa8a6f6a45bf28fae1c5cb54ccd6"
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
#line 1 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\_Imports.razor"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/news/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n        td img {\n            max-width: 100%;\n        }\n    </style>\n    ");
            __builder.AddMarkupContent(1, "<div class=\"section-header\">\n        <h1>Haber Detay</h1>\n    </div>\n    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", "display:block;");
            __builder.AddMarkupContent(5, "\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\n                ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-sm table-bordered table-striped");
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\n                        ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "<th>ID</th>");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 15 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                            news.NewsID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                        ");
            __builder.OpenElement(22, "tr");
            __builder.AddMarkupContent(23, "<th>Kategori</th>");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 16 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                                  news.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                        ");
            __builder.OpenElement(27, "tr");
            __builder.AddMarkupContent(28, "<th>Başlık</th>");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 17 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                                news.Topic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n                        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "<th>İçerik</th>");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 18 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                                news.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "<th>Resim Yolu</th>");
            __builder.OpenElement(39, "td");
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", "/assets/" + (
#nullable restore
#line 19 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                                                      news.ImagePath

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
            __builder.AddAttribute(46, "class", "btn btn-warning");
            __builder.AddAttribute(47, "href", 
#nullable restore
#line 23 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
                                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(49, "Düzenle");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(51);
            __builder.AddAttribute(52, "class", "btn btn-secondary");
            __builder.AddAttribute(53, "href", "/admin/news");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "Geri Dön");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Details.razor"
            [Inject]
        public PortalDbContext Repository { get; set; }

        [Parameter]
        public long Id { get; set; }

        public News news { get; set; }

        protected override void OnParametersSet()
        {
            news = Repository.News.AsQueryable().Include(x => x.Category).FirstOrDefault(p => p.NewsID == Id);
        }

        public string EditUrl => $"/admin/news/edit/{news.NewsID}"; 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
