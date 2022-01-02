#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfd4b8d1317892c1b8c62e96508768cabea50478"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/categories")]
    public partial class Categories : OwningComponentBase<PortalDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"section-header\">\r\n    <h1>Kategoriler</h1>\r\n</div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddAttribute(3, "style", "display:block;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-sm table-striped table-bordered");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddMarkupContent(14, "<thead>\r\n                    <tr><th colspan=\"5\" class=\"text-center\">Kategoriler</th></tr>\r\n                </thead>\r\n                ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.AddMarkupContent(17, "<tr>\r\n                        <th>ID</th>\r\n                        <th>Kategori Adı</th>\r\n                        <th>Renk</th>\r\n                        <th>Düzenle</th>\r\n                        <th>Sil</th>\r\n                    </tr>\r\n");
#nullable restore
#line 21 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                     if (CategoriesList?.Count() > 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                         foreach (Category o in CategoriesList)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                            ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 26 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                     o.CategoryID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 27 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                     o.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "color:" + (
#nullable restore
#line 28 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                                  o.Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, 
#nullable restore
#line 28 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                                            o.Color

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                                ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\r\n                                    ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "btn btn-sm btn-warning");
            __builder.AddAttribute(35, "href", 
#nullable restore
#line 30 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                                                             EditCategory(o.CategoryID)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(36, "\r\n                                        Düzenle\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "td");
            __builder.AddMarkupContent(40, "\r\n                                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-sm btn-danger");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                                                        e => DeleteCategory(o)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                                        Sil\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 41 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                          }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "                        ");
            __builder.AddMarkupContent(49, "<tr><td colspan=\"5\" class=\"text-center\">Kategori Bulunamadı</td></tr>\r\n");
#nullable restore
#line 45 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "href", "/admin/categories/create");
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(57, "Oluştur");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(58, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Pages\Admin\Categories.razor"
               

            public PortalDbContext Repository => Service;

            public IEnumerable<Category> CategoriesList { get; set; }

            protected async override Task OnInitializedAsync()
            {
                await RefreshTable();
            }
            private async Task RefreshTable()
            {
                CategoriesList = await Repository.Categories.ToListAsync();
            }



            public string EditCategory(int id) => $"/admin/categories/edit/{id}";
            public async Task DeleteCategory(Category p)
            {
                //silinecek kategoriye bağlı olan haberlerin kategorileri değiştiriliyor
                var listNews = Repository.News.Where(x => x.Category.CategoryID == p.CategoryID).ToList();
                foreach (var item in listNews)
                {
                    item.Category = Repository.Categories.FirstOrDefault(x => x.CategoryID != p.CategoryID);
                    Repository.News.Update(item);
                }
                Repository.SaveChanges();
                Repository.Categories.Remove(p);
                Repository.SaveChanges();
                await RefreshTable();
            }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591