using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class SalasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
