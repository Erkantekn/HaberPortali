#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dbfa10d80c9564744bae403d15be457fdba4059"
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
#line 1 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\_Imports.razor"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/news/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/news/create")]
    public partial class Editor : OwningComponentBase<PortalDbContext>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    div.validation-message {\r\n        color: rgb(220, 53, 69);\r\n        font-weight: 500\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "section-header");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "h1");
            __builder.AddContent(5, "Haber ");
            __builder.AddContent(6, 
#nullable restore
#line 15 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
               TitleText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-12");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(21);
            __builder.AddAttribute(22, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                 news

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                      SaveNews

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n");
#nullable restore
#line 23 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                     if (news.NewsID != 0)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(28, "                        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\r\n                            ");
                __builder2.AddMarkupContent(32, "<label>Id</label>\r\n                            ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateInputNumber_0(__builder2, 33, 34, "form-control", 35, true, 36, 
#nullable restore
#line 27 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                           news.NewsID

#line default
#line hidden
#nullable disable
                , 37, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => news.NewsID = __value, news.NewsID)), 38, () => news.NewsID);
                __builder2.AddMarkupContent(39, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 29 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "                    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.AddMarkupContent(45, "<label>Başlık</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                     news.Topic

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => news.Topic = __value, news.Topic))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => news.Topic));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                        ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_1(__builder2, 52, 53, 
#nullable restore
#line 33 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                  () => news.Topic

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.AddMarkupContent(59, "<label>Kategori</label>\r\n                        ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateInputSelect_2(__builder2, 60, 61, "form-control", 62, 
#nullable restore
#line 37 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                       SelectedCategoryId

#line default
#line hidden
#nullable disable
                , 63, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => SelectedCategoryId = __value, SelectedCategoryId)), 64, () => SelectedCategoryId, 65, (__builder3) => {
                    __builder3.AddMarkupContent(66, "\r\n");
#nullable restore
#line 38 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                             foreach (var item in Categories)
                            {
                                if (news.NewsID > 0 && item.CategoryID == news.Category.CategoryID)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(67, "                                    ");
                    __builder3.OpenElement(68, "option");
                    __builder3.AddAttribute(69, "value", 
#nullable restore
#line 42 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                    item.CategoryID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(70, "selected", true);
                    __builder3.AddContent(71, 
#nullable restore
#line 42 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                               item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddContent(72, " ");
#nullable restore
#line 42 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                                                  }
                                else
                                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(73, "                                    ");
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 45 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                    item.CategoryID

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, 
#nullable restore
#line 45 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                      item.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 45 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                                        }
                            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(77, "\r\n                        ");
                }
                );
                __builder2.AddMarkupContent(78, "\r\n                        ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_3(__builder2, 79, 80, 
#nullable restore
#line 49 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                  () => news.Category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(81, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.AddMarkupContent(85, "\r\n                        ");
                __builder2.AddMarkupContent(86, "<label>İçerik</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(87);
                __builder2.AddAttribute(88, "class", "form-control");
                __builder2.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                         news.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => news.Content = __value, news.Content))));
                __builder2.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => news.Content));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(92, "\r\n                        ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_4(__builder2, 93, 94, 
#nullable restore
#line 54 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                  () => news.Content

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n                    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group");
                __builder2.AddMarkupContent(99, "\r\n                        \r\n                        ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-md-12");
                __builder2.AddMarkupContent(102, "\r\n                            ");
                __builder2.AddMarkupContent(103, "<label>Resim</label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "class", "form-control");
                __builder2.AddAttribute(106, "disabled", true);
                __builder2.AddAttribute(107, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                         news.ImagePath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => news.ImagePath = __value, news.ImagePath))));
                __builder2.AddAttribute(109, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => news.ImagePath));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(110, "\r\n                            ");
                __Blazor.NewsPortal.Pages.Admin.Editor.TypeInference.CreateValidationMessage_5(__builder2, 111, 112, 
#nullable restore
#line 62 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                      () => news.ImagePath

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n\r\n\r\n");
#nullable restore
#line 67 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                 if (!string.IsNullOrEmpty(news.ImagePath))
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(115, "                                    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-md-12");
                __builder2.AddAttribute(118, "style", "margin:20px 0px;");
                __builder2.AddMarkupContent(119, "\r\n                                        ");
                __builder2.OpenElement(120, "img");
                __builder2.AddAttribute(121, "src", "/assets/" + (
#nullable restore
#line 70 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                           news.ImagePath

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "style", "max-width:150px;");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n");
#nullable restore
#line 72 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(125, "                                ");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "col-md-12");
                __builder2.AddMarkupContent(128, "\r\n\r\n                                    ");
                __builder2.OpenElement(129, "input");
                __builder2.AddAttribute(130, "type", "file");
                __builder2.AddAttribute(131, "class", "btn btn-secondary");
                __builder2.AddElementReferenceCapture(132, (__value) => {
#nullable restore
#line 75 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                            inputTypeFileElement = __value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                                    ");
                __builder2.OpenElement(134, "button");
                __builder2.AddAttribute(135, "type", "button");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
                                                                   ReadFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "class", "btn btn-primary");
                __builder2.AddMarkupContent(138, "Seçilen Resimi Yükle");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n                                \r\n\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n\r\n\r\n                    ");
                __builder2.AddMarkupContent(142, "<button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(143);
                __builder2.AddAttribute(144, "class", "btn btn-secondary");
                __builder2.AddAttribute(145, "href", "/admin/news");
                __builder2.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(147, "İptal");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(148, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(149, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 90 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal for somee\NewsPortal\Pages\Admin\Editor.razor"
       

    public PortalDbContext Repository => Service;

    [Inject]
    public NavigationManager NavManager { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    [Parameter]
    public string SelectedCategoryId { get; set; }



    public News news { get; set; } = new News();
    public List<Category> Categories { get; set; } = new List<Category>();

    private ElementReference inputTypeFileElement;
    private string oldImagePath;
    public async Task ReadFile()
    {
        foreach (var file in await fileReaderService.CreateReference(inputTypeFileElement).EnumerateFilesAsync())
        {
            string rootpath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot");
            var fileInfo = await file.ReadFileInfoAsync();
            string fileName = fileInfo.Name;

            fileName = Path.GetFileNameWithoutExtension(fileName) + Guid.NewGuid() + Path.GetExtension(fileName);
            // Read into buffer and act (uses less memory)
            await using (var fileStream = new FileStream(rootpath + "\\assets\\images\\news\\" + fileName, FileMode.Create, FileAccess.Write))
            await using (Stream stream = await file.OpenReadAsync())
            {
                //// Do (async) stuff with stream...
                await stream.CopyToAsync(fileStream);
            }
            oldImagePath = news.ImagePath;
            news.ImagePath = "images\\news\\" + fileName;

        }
    }


    protected override void OnParametersSet()
    {
        Categories = Repository.Categories.ToList();
        SelectedCategoryId = Categories.FirstOrDefault().CategoryID.ToString();
        if (Id != 0)
        {
            news = Repository.News.AsQueryable().Include(x => x.Category).FirstOrDefault(p => p.NewsID == Id);
            SelectedCategoryId = news.Category.CategoryID.ToString();
        }
        else
        {
            news.Category = Categories.FirstOrDefault();
        }



    }

    public void SaveNews()
    {
        news.Category = Repository.Categories.FirstOrDefault(x => x.CategoryID == int.Parse(SelectedCategoryId));
        if (Id == 0)
        {

            Repository.News.Add(news);
        }
        else
        {
            if (!string.IsNullOrEmpty(oldImagePath))
            {
                if (!String.IsNullOrEmpty(news.ImagePath))
                {
                    File.Delete(System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "wwwroot") + "\\assets\\" + oldImagePath);
                }
            }
            Repository.News.Update(news);
        }
        Repository.SaveChanges();
        NavManager.NavigateTo("/admin/news");
    }

    public string TitleText => Id == 0 ? "Ekle" : "Düzenle";

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileReaderService fileReaderService { get; set; }
    }
}
namespace __Blazor.NewsPortal.Pages.Admin.Editor
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "disabled", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
