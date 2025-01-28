using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}