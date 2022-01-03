#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a19e6e7005a19ca59f3b00c5e49d70d482392f7f"
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
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/news")]
    public partial class NewsPage : OwningComponentBase<PortalDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    td img {\n        max-width: 100%;\n    }\n</style>\n");
            __builder.AddMarkupContent(1, "<div class=\"section-header\">\n    <h1>Haberler</h1>\n</div>\n\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "style", "display:block;");
            __builder.AddMarkupContent(5, "\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.AddMarkupContent(8, "\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.AddMarkupContent(11, "\n\n\n            ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(14, "\n                ");
            __builder.AddMarkupContent(15, @"<thead>
                    <tr>
                        <th>ID</th>
                        <th>Kategori</th>
                        <th>Başlık</th>
                        <th>İçerik</th>
                        <th>Resim Yolu</th>
                        <th>-</th>
                    </tr>
                </thead>
                ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\n");
#nullable restore
#line 30 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
                     if (NewsData?.Count() > 0)
                    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
         foreach (News p in NewsData)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 35 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
         p.NewsID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 36 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
         p.Category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 37 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
         p.Topic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 38 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
         p.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\n    ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "src", "/assets/" + (
#nullable restore
#line 39 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
                           p.ImagePath

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\n    ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(38);
            __builder.AddAttribute(39, "class", "btn btn-info btn-sm");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 42 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
                        GetDetailsUrl(p.NewsID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\n            Detay\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "btn btn-warning btn-sm");
            __builder.AddAttribute(46, "href", 
#nullable restore
#line 46 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
                        GetEditUrl(p.NewsID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "\n            Düzenle\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\n        ");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
                            e => DeleteNews(p)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "\n            Sil\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\n");
#nullable restore
#line 55 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
  }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<tr>\n    <td colspan=\"5\" class=\"text-center\">Haber Bulunamadı</td>\n</tr>\n");
#nullable restore
#line 61 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\n\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(61);
            __builder.AddAttribute(62, "class", "btn btn-primary");
            __builder.AddAttribute(63, "href", "/admin/news/create");
            __builder.AddAttribute(64, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(65, "Oluştur");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Pages\Admin\NewsPage.razor"
        public PortalDbContext Repository => Service;

    public IEnumerable<News> NewsData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        NewsData = await Repository.News.AsQueryable().Include(x => x.Category).ToListAsync();
    }

    public async Task DeleteNews(News p)
    {
        if (!String.IsNullOrEmpty(p.ImagePath))
        {
            File.Delete(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot") + "\\assets\\" + p.ImagePath);
        }
        Repository.News.Remove(p);
        Repository.SaveChanges();
        await UpdateData();
    }

    public string GetDetailsUrl(long id) => $"/admin/news/details/{id}";
    public string GetEditUrl(long id) => $"/admin/news/edit/{id}"; 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
