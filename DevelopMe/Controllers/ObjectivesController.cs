using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevelopMe.Controllers
{
    public class ObjectivesController : Controller
    {
        public IActionResult NewObjective()
        {
            return View();
        }
    }
}