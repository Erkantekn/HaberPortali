using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NewsPortal.Models.ViewModels;
using System.Collections.Generic;

namespace NewsPortal.Infrastructure {

    [HtmlTargetElement("category-span")]
    public class CategorySpanTagHelper : TagHelper {
        private IUrlHelperFactory urlHelperFactory;

        public CategorySpanTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }

        public string Action { get; set; }
        public string SpanClass { get; set; }
        public string BackgroundColor { get; set; }
        public string Text { get; set; }
        public override void Process(TagHelperContext context,
                TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder span = new TagBuilder("span");
            span.Attributes["style"] = "background-color:" + BackgroundColor + " !important";
            span.AddCssClass(SpanClass);

            TagBuilder tag = new TagBuilder("a");
            tag.Attributes["href"] = urlHelper.Action(Action);
            tag.InnerHtml.Append(Text);
            span.InnerHtml.AppendHtml(tag);
            output.Content.AppendHtml(span.InnerHtml);
        }
    }
}
