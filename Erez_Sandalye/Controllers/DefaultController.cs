using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Erez_Sandalye.Controllers
{
    public class DefaultController : Controller
    {
		private readonly IProductDal _productDal;

		public DefaultController(IProductDal productDal)
		{
			_productDal = productDal;
		}

		public IActionResult Index()
		{
			var products = _productDal.GetListAll();
			return View(products); // Ana view'e ürün listesini model olarak gönderiyoruz
		}
		public PartialViewResult HeadPartial()
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
		public PartialViewResult FooterPartial()
		{
			return PartialView();
		}
		public PartialViewResult HeaderPartial()
		{
			return PartialView();
		}
		public PartialViewResult BannerPartial()
		{
			return PartialView();
		}
		public PartialViewResult ReferencePartial()
		{
			return PartialView();
		}
		public PartialViewResult ProductPartial()
		{
			return PartialView();
		}
		public PartialViewResult TestimonialPartial()
		{
			return PartialView();
		}
	}
}
