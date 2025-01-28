using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}