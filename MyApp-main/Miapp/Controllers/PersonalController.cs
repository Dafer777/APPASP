using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Miapp.Models;

namespace Miapp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Persona person=new Persona();
            person.name="David Isaac";
            person.lastname="Fernandez Chicas";
            person.years=19;
            person.email="Isaacdavid959@gmail.com";
            person.tel="7280-9747";
            person.dir="San Francisco Gotera Morazan";

            return View(person);
        }
    }
}