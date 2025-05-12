using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class DisciplinasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
