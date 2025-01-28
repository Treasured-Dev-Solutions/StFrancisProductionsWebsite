using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class ArtsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}