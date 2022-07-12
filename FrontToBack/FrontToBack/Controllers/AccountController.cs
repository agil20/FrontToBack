using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {

            return View();

        }

    }
}
