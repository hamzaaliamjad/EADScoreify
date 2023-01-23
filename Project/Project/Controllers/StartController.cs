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

        public IActionResult signUp()
        {
            return View();
        }


    }
}
