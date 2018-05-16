using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Events.Models;
using Events.Data;

namespace Events.Controllers
{
    public class HomeController : Controller
    {
        private EventsContext _context;
      public HomeController(EventsContext context)
        {
            _context = context;
        }
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
            // UserRepository.AddUser(user);
            user.Created = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
            return View("Thanks",user);
        }

        public IActionResult List(User user)
        {
            // return View(UserRepository.Users);
            return View(_context.Users);
        }







        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
