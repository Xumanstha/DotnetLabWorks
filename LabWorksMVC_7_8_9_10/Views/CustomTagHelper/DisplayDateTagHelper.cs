using Microsoft.AspNetCore.Razor.TagHelpers;

namespace LabWorksMVC_7_8_9_10.Views.CustomTagHelper
{
    public class DisplayDateTagHelper : TagHelper
    {
        public DateTime Date { get; set; }

        public override void Process(
            TagHelperContext context,
            TagHelperOutput output)
        {
            output.TagName = "span";
            output.Content.SetContent(Date.ToString("MM/dd/yyyy"));
        }
    }
}
