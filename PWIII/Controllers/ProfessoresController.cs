using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class ProfessoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
