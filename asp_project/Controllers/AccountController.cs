using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.DataContext;
using WebApplication3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/

        // 로그인
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Login()
        //{
        //    return View();
        //}
        // 회원가입

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                // Java try(sqlsession) {} catch() {}

                // C#
                using(var db = new NoteDBContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
