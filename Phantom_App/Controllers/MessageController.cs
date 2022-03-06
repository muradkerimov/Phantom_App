using Microsoft.AspNetCore.Mvc;
using Phantom_App.DAL;
using Phantom_App.Models;
using Phantom_App.ViewModel;
using System.Linq;

namespace Phantom_App.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _db;
        public MessageController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeViewModel msg = new HomeViewModel
            {
             messages = _db.Messages.ToList(),
            };
            return View(msg);
        }
    }
}
