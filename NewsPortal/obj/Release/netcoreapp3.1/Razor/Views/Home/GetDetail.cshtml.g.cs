#pragma checksum "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115e50bbc023ed48b68749450096a402d9da730a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetDetail), @"mvc.1.0.view", @"/Views/Home/GetDetail.cshtml")]
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
#line 1 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\_ViewImports.cshtml"
using NewsPortal.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115e50bbc023ed48b68749450096a402d9da730a", @"/Views/Home/GetDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5cc86de06eac85681e7c6757b11220cefe5454", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LayoutModel<News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
  
    ViewData["Title"] = "Detay";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
 if (Model.PageModel != null)
{



#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""editors-news"">
    <div class=""row"">
        <div class=""col-lg-3"">
            <div class=""d-flex position-relative float-left"">
                <h3 class=""section-title""></h3>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-6  mb-5 mb-sm-2"">
            <div class=""position-relative image-hover"">
                <img");
            BeginWriteAttribute("src", " src=\"", 543, "\"", 583, 2);
            WriteAttributeValue("", 549, "/assets/", 549, 8, true);
#nullable restore
#line 22 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
WriteAttributeValue("", 557, Model.PageModel.ImagePath, 557, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"img-fluid\"\r\n                     alt=\"world-news\" />\r\n                <span class=\"thumb-title\"");
            BeginWriteAttribute("style", " style=\"", 709, "\"", 776, 3);
            WriteAttributeValue("", 717, "background-color:", 717, 17, true);
#nullable restore
#line 25 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
WriteAttributeValue("", 734, Model.PageModel.Category.Color, 734, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 765, "!important", 766, 11, true);
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 780, "\"", 841, 2);
            WriteAttributeValue("", 787, "/Home/Category?id=", 787, 18, true);
#nullable restore
#line 25 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
WriteAttributeValue("", 805, Model.PageModel.Category.CategoryID, 805, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
                                                                                                                                                                          Write(Model.PageModel.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></span>
            </div>
           
            
        </div>
        <div class=""col-lg-6  mb-5 mb-sm-2"">
            <div class=""row"">
                <div class=""col-md-12"">

                    <h1 class=""font-weight-600 mt-3"">
                        ");
#nullable restore
#line 35 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
                   Write(Model.PageModel.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h1>\r\n                </div>\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"fs-14 font-weight-normal\">\r\n                        ");
#nullable restore
#line 40 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
                   Write(Model.PageModel.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                </div>\r\n            </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 47 "D:\Ders\3.Sınıf\Web Programlama\Final\NewsPortal new\NewsPortal\Views\Home\GetDetail.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LayoutModel<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
