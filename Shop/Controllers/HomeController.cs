using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Repositories;
using Shop.ViewModels.Home;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid == false)
                return View(model);

            UsersRepository repo = new UsersRepository();
            User loggedUser = repo.GetByUsernameAndPassword(
                                            model.Username,
                                            model.Password);

            if (loggedUser == null)
            {
                ModelState.AddModelError("authFailed", "Authentication failed!");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
