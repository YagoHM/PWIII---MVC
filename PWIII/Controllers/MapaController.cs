using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class MapaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
