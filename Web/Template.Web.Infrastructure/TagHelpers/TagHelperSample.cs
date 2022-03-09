using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Template.Web.Infrastructure.TagHelpers
{
    [HtmlTargetElement("h1")]
    public class HelloTagHelper : TagHelper
    {
        private const string MessageFormat = "Hello, {0}";
        public string TargetName { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string formattedMessage = string.Format(MessageFormat, this.TargetName);
            output.Content.SetContent(formattedMessage);
        }
    }

}
