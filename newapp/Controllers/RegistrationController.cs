using Microsoft.AspNetCore.Mvc;
using newapp.Areas.Identity.Data;
using newapp.Models;

namespace newapp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly newappContext _context;
        public RegistrationController(newappContext context)
        {
            this._context = context;
        }
        public IActionResult Register()
        {
            return View();
        } 
        
        //public IActionResult Register(Registration register)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        _context.Registrations.Add(register);
        //        _context.SaveChanges();


        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(register);
        //}
       public IActionResult login()
        {
            return View();
        }
    }
    
    
}
