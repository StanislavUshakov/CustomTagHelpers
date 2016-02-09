using Microsoft.AspNet.Razor.TagHelpers;
using System;

namespace CustomTagHelpersAndViewComponents.TagHelpers
{
    /// <summary>
    /// Custom TagHelper for generating email links
    /// </summary>
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "example.com";

        /// <summary>
        /// The email address without domain
        /// </summary>
        public string MailTo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (output == null)
            {
                throw new ArgumentNullException(nameof(output));
            }

            output.TagName = "a";
            string address = MailTo + "@" + EmailDomain;
            output.Attributes["href"] = "mailto:" + address;
            output.Content.SetContent(address);
        }
    }
}
