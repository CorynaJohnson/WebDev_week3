using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_2_web_design.Data;
using lab_2_web_design.Models;

namespace lab_2_web_design.Controllers
{
    public class UserController1 : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var Users = Database.Users;
            return View(Users);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            Database.Users.Add(user);

            return RedirectToAction("Index");
        }
    }
}