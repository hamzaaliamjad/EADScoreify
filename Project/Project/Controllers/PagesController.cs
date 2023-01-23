using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult profile()
        {
            return View();
        }

        public IActionResult edit()
        {
            return View();
        }

        public IActionResult feed()
        {
            return View();
        }
    }
}
