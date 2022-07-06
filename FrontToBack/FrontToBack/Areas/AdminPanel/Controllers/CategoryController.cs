using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class CategoryController : Controller
    { 
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {

            if (!ModelState.IsValid)
            {
                return View();

            }
            bool existNNameCtegory = _context.Categories.Any(x => x.Name.ToLower() == category.Name.ToLower());
            if (existNNameCtegory)
            {
                ModelState.AddModelError("Name", "Bu adli category Var");
            }
            Category newCategory = new Category
            {
         Name = category.Name,
          Desc=category.Desc,
      


            };
         await   _context.Categories.AddAsync(newCategory);
            await _context.SaveChangesAsync();
            return RedirectToAction("index");

        }
        public async Task<IActionResult> Detail(int? id) 
        
        {
            if (id==null) return NotFound();
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        public async Task<IActionResult> Update(int? id)

        {
            if (id == null) return NotFound();
            Category category = await _context.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
   
        public async Task<IActionResult> Update(Category category)

        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category dbcategory = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (dbcategory == null) return NotFound();
            dbcategory.Name = category.Name;
            dbcategory.Desc = category.Desc;
            return View("ookay");
        }




    }



}
