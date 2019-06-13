using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace KenticoCommunity.YouTubeSelectorWidget
{
    public class YouTubeSelectorWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Label = "YouTube Video ID")]
        public string VideoId { get; set; }

    }
}
