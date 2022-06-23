using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
          
            HomeVM homeVm=new HomeVM();
            homeVm.Sliders = _context.Sliders.ToList();
            homeVm.SliderContent = _context.SliderContents.FirstOrDefault();
          homeVm.Categories= _context.Categories.ToList();
            homeVm.Products = _context.Products.Include(p=>p.Id).ToList();
            return View(homeVm);
        }
    }
}
