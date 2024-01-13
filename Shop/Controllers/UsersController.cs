//using Microsoft.AspNetCore.Mvc;
//using Shop.Entities;
//using Shop.Extentions;
//using Shop.Filters;
//using Shop.Repositories;
//using Shop.ViewModels.Users;

//namespace Shop.Controllers
//{
   
//    [AuthenticationFilter]
//    public class UsersController : Controller
//    {
//        public IActionResult Index()
//        {
//            UsersRepository repo = new UsersRepository();

//            IndexVM model = new IndexVM();
//            model.Items = repo.GetAll();

//            return View(model);
//        }

//        [HttpGet]
//        public IActionResult Create()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Create(CreateVM model)
//        {
//            if (!ModelState.IsValid)
//                return View(model);

//            UsersRepository repo = new UsersRepository();

//            User toAdd = new User();
//            toAdd.Username = model.Username;
//            toAdd.Password = model.Password;
//            toAdd.FirstName = model.FirstName;
//            toAdd.LastName = model.LastName;

//            repo.Save(toAdd);

//            return RedirectToAction("Index", "Users");
//        }

//        [HttpGet]
//        public IActionResult Edit(int id)
//        {
//            UsersRepository repo = new UsersRepository();
//            User toEdit = repo.GetById(id);

//            if (toEdit == null)
//                return RedirectToAction("Index", "Users");

//            EditVM model = new EditVM();
//            model.Id = toEdit.Id;
//            model.Username = toEdit.Username;
//            model.Password = toEdit.Password;
//            model.FirstName = toEdit.FirstName;
//            model.LastName = toEdit.LastName;

//            return View(model);
//        }

//        [HttpPost]
//        public IActionResult Edit(EditVM model)
//        {
//            if (!ModelState.IsValid)
//                return View(model);

//            UsersRepository repo = new UsersRepository();
//            User toEdit = repo.GetById(model.Id);

//            if (toEdit == null)
//                return RedirectToAction("Index", "Users");

//            toEdit.Username = model.Username;
//            toEdit.Password = model.Password;
//            toEdit.FirstName = model.FirstName;
//            toEdit.LastName = model.LastName;

//            repo.Save(toEdit);

//            return RedirectToAction("Index", "Users");
//        }

//        public IActionResult Delete(int id)
//        {
//            UsersRepository repo = new UsersRepository();

//            User toDelete = repo.GetById(id);

//            if (toDelete != null)
//                repo.Delete(toDelete);

//            return RedirectToAction("Index", "Users");
//        }
//    }
//}
