using Microsoft.AspNetCore.Mvc;

namespace PWIII.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
