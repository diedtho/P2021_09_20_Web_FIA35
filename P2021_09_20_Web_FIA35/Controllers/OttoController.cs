using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2021_09_20_Web_FIA35.Controllers
{
    public class OttoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
