using System;
using System.Threading.Tasks;
using Microsoft.AspNet.Razor.TagHelpers;

namespace CustomTagHelpersAndViewComponents.TagHelpers
{
    /// <summary>
    /// Custom tag helper for generating copyright information. Content inside will be added after: &copy; Year
    /// </summary>
    [HtmlTargetElement("copyright")]
    public class CopyrightTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            var content = await output.GetChildContentAsync();
            string copyright = $"<p>&copy; {DateTime.Now.Year} {content.GetContent()}";
            output.Content.SetHtmlContent(copyright);
        }
    }
}
