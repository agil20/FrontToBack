using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Products.Include(p=>p.Category).ToList());
        }
        public async Task<IActionResult> Detail(int? id)

        {
            if (id == null) return NotFound();
            Product product = await _context.Products.Include(p=>p.Category).FirstOrDefaultAsync(p=>p.Id==id);
            if (product == null) return NotFound();
            return View(product);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (product.Photo==null)
            {
                ModelState.AddModelError("Photo", "Bosqoyma");
            }
          
          
            ViewBag.Categories = _context.Categories.ToList();

            return View();

        }
    }
}
