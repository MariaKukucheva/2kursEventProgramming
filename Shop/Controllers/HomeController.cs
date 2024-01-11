using Microsoft.AspNetCore.Mvc;
//using Shop.ActionFilters;
//using Shop.Repositories;
//using Shop.Entities;
//using Shop.ExtentionMethods;
//using Shop.Models;
using Shop.ViewModels.Home;
using System.Diagnostics;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult ShoppingCart()
        {
            return View();
        }
        public IActionResult CreateVM()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}



       

        //[HttpGet]
        //public IActionResult Login()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Login(LoginVM model)
        //{
        //    if (!this.ModelState.IsValid)
        //        return View(model);

        //    ShopDbContext context = new ShopDbContext();
        //    User loggedUser = context.Users.Where(u => u.Username == model.Username &&
        //                                               u.Password == model.Password)
        //                                   .FirstOrDefault();
        //    if (loggedUser == null)
        //    {
        //        this.ModelState.AddModelError("authError", "Invalid username or password!");
        //        return View(model);
        //    }

        //    HttpContext.Session.SetObject("loggedUser", loggedUser);

        //    return RedirectToAction("Index", "Home");
        //}

        //[AuthenticationFilter]
        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Remove("loggedUser");

        //    return RedirectToAction("Login", "Home");
        //}
    }
}