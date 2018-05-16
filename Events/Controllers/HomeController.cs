using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events.Models;

namespace Events.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            ViewBag.messege = "Cześć Łukasz";
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            UserRepository.AddUser(user);
            return View("Thanks",user);
        }

        public IActionResult List(User user)
        {        
            return View(UserRepository.Users);
        }







        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
