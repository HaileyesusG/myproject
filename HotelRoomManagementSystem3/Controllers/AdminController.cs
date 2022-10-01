using HotelRoomManagementSystem3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebFinalProject.Models.Service;

namespace HotelRoomManagementSystem3.Controllers
{
    public class AdminController : Controller
    {
        
        private readonly Csharp2Context _context;
        private readonly IGenericService<Reservation1> _service;
        public AdminController(Csharp2Context context, IGenericService<Reservation1> service)
        {
            _service = service;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(staff st)
        {
            HttpContext.Session.SetString("Test", "2");
          var dss=  _context.staff.Where(x => x.StaffName == st.StaffName && x.StaffPassword == st.StaffPassword).Count();
            if(dss>0)
            {
                return RedirectToAction("DashBoard");
            }
            else
            {
                TempData["ErrorMessage"] = "Incoorect UserName Or PassWord";
                return View();
            }
            
        }
        
        public IActionResult DashBoard(string search="")
        {
            ViewBag.session= HttpContext.Session.GetString("Test");
          
           // x = HttpContext.Session.GetString("Test2");

            
                ViewBag.search = search;
                var data = _context.Reservation1s.Where(x => x.FcilentName.StartsWith(search) || search == null).ToList();
                return View(data);
            
           // return RedirectToAction("Illegal");

        }
        public IActionResult Illegal()
        {
            return View();
            
        }
        public IActionResult Logout()
        {
            HttpContext.Session.SetString("Test", "3");
            return RedirectToAction("login");

        }
    }
}
