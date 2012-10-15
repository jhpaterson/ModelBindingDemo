using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingDemo.Models;

namespace ModelBindingDemo.Controllers
{
    public class HomeController : Controller
    {
        UserRepository repository = new UserRepository();  // sorry, no DI here!

        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        [HttpGet]
        public ActionResult SimpleForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleForm(
            [Bind(Exclude="IsApproved")] User user)
        {
            return View("ShowUser", user);
        }

        [HttpGet]
        public ActionResult RogueForm()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ComplexObjectForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ComplexObjectForm(User user)
        {
            return View("ShowUser", user);
        }

        [HttpGet]
        public ActionResult SimpleList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SimpleList(List<string> roles)
        {
            return View("ShowList",roles);
        }

        [HttpGet]
        public ActionResult UserList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserList(List<User> users)
        {
            return View("ShowUserList", users);
        }

        [HttpGet]
        public ActionResult UserDictionary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserDictionary(Dictionary<string, User> users)
        {
            return View("ShowUserDictionary", users);
        }

        [HttpGet]
        public ActionResult ComplexList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ComplexList(User user)
        {
            return View("ShowUser", user);
        }

        [HttpGet]
        public ActionResult UpdateForm()
        {
            User user = repository.GetSomeUser();
            return View(user);
        }

        [HttpPost]
        public ActionResult UpdateForm(FormCollection formData)
        {
            User user = repository.GetSomeUser();
            UpdateModel(user, formData);
            return View("ShowUser", user);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
