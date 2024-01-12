//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Shop.Data;
//using Shop.Entities;
//using Shop.Models;
//using System;

//namespace Shop.Controllers
//{
//    public class RegistrationController : Controller
//    {
//        private readonly AppDbContext _context;

//        public RegistrationController(AppDbContext context)
//        {
//            _context = context;
//        }

//        [HttpGet]
//        public IActionResult Registration()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Index(RegistrationModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                if (!ModelState.IsValid)
//                    return View(model);

//                User item = new User();
//                item.Username = model.Username;
//                item.Password = model.Password;
//                item.Email = model.Email;

//                AppDbContext context = new AppDbContext();
//                context.Users.Add(item);
//                context.SaveChanges();

//                return RedirectToAction("Index", "Users");

//            }

//            return View(model);
//        }
//    }
//}
