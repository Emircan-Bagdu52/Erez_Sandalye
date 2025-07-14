using Microsoft.AspNetCore.Mvc;

namespace Erez_Sandalye.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
