#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7c03fd34f1ba49e8f0bbf97899ad0e6ea6cb0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Category), @"mvc.1.0.view", @"/Views/Home/Category.cshtml")]
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
#line 1 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7c03fd34f1ba49e8f0bbf97899ad0e6ea6cb0be", @"/Views/Home/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5cc86de06eac85681e7c6757b11220cefe5454", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LayoutModel<List<News>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
  
    ViewData["Title"] = "Kategori Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
 if (Model.PageModel.Count > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"popular-news\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-3\">\r\n                <div class=\"d-flex position-relative float-left\">\r\n                    <h3 class=\"section-title\">");
#nullable restore
#line 13 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                                         Write(Model.PageModel.FirstOrDefault().Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 20 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                         foreach (var item in Model.PageModel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-4  mb-5 mb-sm-2\">\r\n\r\n                        <div class=\"position-relative image-hover\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 840, "\"", 869, 2);
            WriteAttributeValue("", 846, "/assets/", 846, 8, true);
#nullable restore
#line 25 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
WriteAttributeValue("", 854, item.ImagePath, 854, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                 class=\"img-fluid\"\r\n                                 alt=\"world-news\" />\r\n                            <span class=\"thumb-title\"");
            BeginWriteAttribute("style", " style=\"", 1031, "\"", 1087, 3);
            WriteAttributeValue("", 1039, "background-color:", 1039, 17, true);
#nullable restore
#line 28 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
WriteAttributeValue("", 1056, item.Category.Color, 1056, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1076, "!important", 1077, 11, true);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 1091, "\"", 1141, 2);
            WriteAttributeValue("", 1098, "/Home/Category?id=", 1098, 18, true);
#nullable restore
#line 28 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
WriteAttributeValue("", 1116, item.Category.CategoryID, 1116, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                                                                                                                                                                Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                        </div>\r\n                        <h5 class=\"font-weight-bold mt-3\">\r\n                            ");
#nullable restore
#line 31 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                       Write(item.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <p class=\"fs-15 font-weight-normal\">\r\n                            ");
#nullable restore
#line 34 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                       Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1500, "\"", 1538, 2);
            WriteAttributeValue("", 1507, "/Home/GetDetail?id=", 1507, 19, true);
#nullable restore
#line 36 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
WriteAttributeValue("", 1526, item.NewsID, 1526, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"font-weight-bold text-dark pt-2\">Devamını Oku</a>\r\n                    </div>\r\n");
#nullable restore
#line 38 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 43 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"



}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"" style=""margin-top:40px;"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""d-flex position-relative float-left"">
                    <h3 class=""section-title"">Burada hiç içerik yok!</h3>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 57 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal\NewsPortal\Views\Home\Category.cshtml"
        }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LayoutModel<List<News>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
