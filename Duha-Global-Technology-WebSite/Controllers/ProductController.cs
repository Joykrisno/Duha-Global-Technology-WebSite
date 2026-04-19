using Microsoft.AspNetCore.Mvc;

namespace Duha_Global_Technology_WebSite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
