using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_intro.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int id, string name)
        {
            return "Home Page" +" "+ id + "-" + name;
        }

        public IActionResult FullName()
        {
            return Json(new { name = "Huseyn", Surname = "Jafarov" });
            //Content()
        }

        public IActionResult Html()
        {
            return View();
        }

        public string FullData(string name, string surname,int age)
        {
            return $"Name--{name}: Surname--{surname}: Age--{age}";
        } 
    }
}
