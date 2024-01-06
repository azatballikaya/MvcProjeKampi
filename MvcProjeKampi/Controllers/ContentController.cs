using Microsoft.AspNetCore.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ContentByHeading(int id)
        {
            return View();
        }
    }
}
