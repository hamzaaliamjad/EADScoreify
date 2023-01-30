using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class StartController : Controller
    {
        public IActionResult landing()
        {
            return View();
        }
        
        public IActionResult signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult signUpHandle(string Name, string username, string password, string Cpassword, string email, string phnNo)
        {
            Models.DB_function db = new Models.DB_function();
            db.addStudent(Name,username,password,Cpassword,email,phnNo);
            return Redirect("/start/signup");
        }
        [HttpPost]
        public IActionResult loginHandle(string username,string password)
        {
            ViewBag.Name = username;
            if (HttpContext.Request.Cookies.ContainsKey("username"))
            {
                ViewBag.Name= HttpContext.Request.Cookies["username"];
            }
            else
            {
                HttpContext.Response.Cookies.Append("username", username.ToString());
            }
            return Redirect("/pages/feed");
        }


    }
}
