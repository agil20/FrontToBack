using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Areas.AdminPanel.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
