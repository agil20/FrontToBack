using FrontToBack.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FrontToBack.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]

    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _rolemanager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> rolemanager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _rolemanager = rolemanager;
        }

        public IActionResult Index(string search)
        {
            var users=search==null?
                _userManager.Users.ToList():_userManager.Users.
                Where(user=>user.FullName.ToLower().Contains(search.ToLower())).ToList();
  

            return View(users);
        }
       
    }
}
