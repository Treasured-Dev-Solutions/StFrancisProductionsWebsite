using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class TrainingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}