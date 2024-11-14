using Microsoft.AspNetCore.Mvc;
using newapp.Areas.Identity.Data;
using newapp.Models;

namespace newapp.Controllers
{
    public class AdminController : Controller
    {
        private readonly newappContext _context;
        public AdminController (newappContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
