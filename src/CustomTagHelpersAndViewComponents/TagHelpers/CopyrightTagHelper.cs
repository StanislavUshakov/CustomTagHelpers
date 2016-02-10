using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.Runtime.TagHelpers;
using Microsoft.AspNet.Razor.TagHelpers;

namespace CustomTagHelpersAndViewComponents.TagHelpers
{
    [HtmlTargetElement("copyright")]
    public class CopyrightTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();
            string copyright = $"<p>&copy; {DateTime.Now.Year} {content.GetContent()}";
            output.Content.SetHtmlContent(copyright);
        }
    }
}
