using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
public ProductController(AppDbContext context)
        {

            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.Take(8).Include(p => p.Category).ToList();
            return View(products);
        }
        public IActionResult LoadMore()
        {
            List<Product> products = _context.Products.Skip(2).Take(2).Include(p=>p.Category).ToList();
            List<ProductReturnVM> productReturnVMs = new List<ProductReturnVM>();
            foreach (var item in products)
            {
                ProductReturnVM productReturnVM = new ProductReturnVM();
                productReturnVM.Id = item.Id;
                productReturnVM.Name = item.Name;
                productReturnVM.ImageUrl = item.ImageUrl;
                productReturnVM.Price = item.Price;
                productReturnVM.Category = item.Category.Name;
                productReturnVMs.Add(productReturnVM);

            }
            return Json(productReturnVMs);
        }
    }
}
