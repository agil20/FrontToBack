using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class BasketController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddItem()
        {
            HttpContext.Session.SetString("Person", "Aqil");
            return Content("");
        }
        public IActionResult ShowItem()
        {
         string name=   HttpContext.Session.GetString("Person");
            return Content(name);
        }
    }
}
