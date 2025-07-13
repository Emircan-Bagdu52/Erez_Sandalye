using Microsoft.AspNetCore.Mvc;

namespace Erez_Sandalye.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
		public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}
		public PartialViewResult FeatureSection()
		{
			return PartialView();
		}
		public PartialViewResult SliderPartial()
		{
			return PartialView();
		}
	}
}
