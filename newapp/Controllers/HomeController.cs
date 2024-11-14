using Microsoft.AspNetCore.Mvc;
using newapp.Areas.Identity.Data;

namespace newapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly newappContext _context;
        public HomeController(newappContext context)
        {
            this._context = context;

        }
        
            public IActionResult Index()
            {
                
                return View();
            }

            
            public IActionResult About()
            {
                return View();
            }
        public IActionResult services()
        {
            return View();
        }

        public IActionResult Contact()
            {
                return View();
            }
        }
    }



