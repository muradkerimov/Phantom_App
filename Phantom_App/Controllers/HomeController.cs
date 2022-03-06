using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Phantom_App.DAL;
using Phantom_App.Models;
using Phantom_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Phantom_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            ViewBag.Style = 0;
            HomeViewModel phantom = new HomeViewModel
            {
                headers = _db.Headers.FirstOrDefault(),
                projects = _db.Projects.ToList(),
            };
            return View(phantom);
        }

        public IActionResult addMessage(string name, string email, string message)
        {
            Message msg = new Message();
            msg.UserName = name;
            msg.UserEmail = email;
            msg.Text = message;
            msg.MessageDate = DateTime.Now;
            _db.Messages.Add(msg);
            _db.SaveChanges();
            TempData["messageAdded"] = "Your message was added successsfully";
            return RedirectToAction("Index", "Home");
        }
    }
}
