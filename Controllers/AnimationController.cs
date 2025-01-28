using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class AnimationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}