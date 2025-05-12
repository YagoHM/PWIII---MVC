using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
