using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_intro.Controllers
{
    public class ContactController : Controller
    {
        public string Index()
        {
            return "Contact Page";
        }
    }
}
