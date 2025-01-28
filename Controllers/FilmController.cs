using Microsoft.AspNetCore.Mvc;

namespace StFPWebsite.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}