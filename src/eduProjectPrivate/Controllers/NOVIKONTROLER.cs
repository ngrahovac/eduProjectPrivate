using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eduProjectPrivate.Controllers
{
    public class NOVIKONTROLER : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
