using Kentico.PageBuilder.Web.Mvc;
using KenticoCommunity.YouTubeSelectorWidget;
using System.Configuration;
using System.Web.Mvc;

[assembly: RegisterWidget("KenticoCommunity.YouTubeSelectorWidget", typeof(YouTubeSelectorWidgetController), "YouTube selector widget", Description = "Shows selected YouTube video", IconClass = "icon-brand-youtube")]

namespace KenticoCommunity.YouTubeSelectorWidget
{
    public class YouTubeSelectorWidgetController : WidgetController<YouTubeSelectorWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();

            var viewModel = new YouTubeSelectorWidgetViewModel
            {
                VideoId  = properties.VideoId,
                ApiKey = ConfigurationManager.AppSettings["YouTubeApiKey"]
            };


            return PartialView("Widgets/YouTubeSelectorWidget/_YouTubeSelectorWidget", viewModel);
        }
    }
}
