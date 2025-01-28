using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class EventssController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}