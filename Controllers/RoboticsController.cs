using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class RoboticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}