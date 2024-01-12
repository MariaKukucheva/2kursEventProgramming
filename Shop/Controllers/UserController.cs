//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace Shop.Controllers
//{
//    public class UserController : Controller
//    {
//        //private readonly AppDbContext _context;

//        //public UserController(AppDbContext context) => _context = context;
//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Login(string username, string password)
//        {
//            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

//            if (user != null)
//            {
//                // Успешен вход - например, използвайки ASP.NET Core Identity или сесии
//                return RedirectToAction("Index", "Home");
//            }

//            ModelState.AddModelError("", "Невалиден опит за вход");
//            return View();
//        }
//    }
//}
