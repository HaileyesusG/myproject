using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebFinalProject.Models;
using Microsoft.AspNetCore.Routing;

using HotelRoomManagementSystem3.Models;
using WebFinalProject.Models.Service;

namespace WebFinalProject.Controllers
{
    public class ReservationController : Controller
    {
        private readonly Csharp2Context _context;
        private readonly IGenericService<Reservation1> _service;
        private readonly IGenericService<Room> _service2;

        public ReservationController(IGenericService<Reservation1> service, IGenericService<Room> service2, Csharp2Context context)
        {
            _context = context;
            _service = service;
            _service2 = service2;
        }
        public IActionResult Index()
        {
            var pro = _service2.GetAll();
            return View(pro);
        }

        public IActionResult Create(int ? id)
        {

            var pro = _service2.GetById(id);
            ViewBag.id = id;
            ViewBag.type = pro.Roomtype;
            ViewBag.pay = pro.PaymentAmount;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Reservation1 reserve)
        {
            try
            {
if(ModelState.IsValid==true)
            {
                _service.Add(reserve);
                    return RedirectToAction("DsplayReservDetail", new RouteValueDictionary(new { Controller = "Reservation", Action = "DsplayReservDetail", id = reserve.Resid }));
                //return View(reserve);
            }

            }
            catch (Exception)
            {

                throw;
            }

            TempData["successMessage"] = "Created Successfully";
            return View();
            


        }


        [HttpPost]
        public IActionResult Edit(Reservation1 reserve)
        {
            var cc = _context.Reservation1s.Where(x => x.Room == reserve.Room).Count();
            if (cc > 1)
            {
                TempData["ErrorMessage"] = "ERROR!!  Room " + reserve.Room + " is ready Reserved";
                return View();
            }
            else
            {
                _service.Update(reserve);
                TempData["successMessage"] = "Updated Successfully";
                return RedirectToAction("DsplayGuestDetail", new RouteValueDictionary(new { Controller = "Reservation", Action = "DsplayGuestDetail", id = reserve.Resid }));
            }
            //return View(reserve);
        }



        public IActionResult DsplayReserv()
        {
            var data = _service.GetAll();

            return View(data);
        }
        public IActionResult DsplayReservDetail(int? id)
        {
            var data = _service.GetById(id);
            TempData["successMessage"] = "Created Successfully";
            return View(data);
        }

        public IActionResult DsplayGuestDetail(int? id)
        {
            var data = _service.GetById(id);

            return View(data);
        }

        public IActionResult Delete(int? id)
        {
            var dd= _service.GetById(id);

            return View(dd);
        }
        [HttpPost]
        public IActionResult Delete(Reservation1 r, int? id)
        {
            try
            {

                _service.Delete(id);
                TempData["successMessage"] = "Deleted Successfully";
                return RedirectToAction("DashBoard", new RouteValueDictionary(new { Controller = "Admin", Action = "DashBoard" }));

            }
            catch
            {
                throw;
            }
           
            
        }

        public IActionResult GuestLogIn()
        {

            return View();
        }

        [HttpPost]
        public IActionResult GuestLogIn(Reservation1 st)
        {

            var dss = _context.Reservation1s.Where(x =>x.Resid == st.Resid ).Count();
            if (dss > 0)
            {
                return RedirectToAction("DsplayGuestDetail", new RouteValueDictionary(new { Controller = "Reservation", Action = "DsplayGuestDetail", id = st.Resid }));
            }
            else
            {
                 
                ModelState.AddModelError("", "incorrect Password");
                TempData["ErrorMessage"] = "incorrect Password";
                return View();
            }

        }
        public IActionResult SingleRoom(string val)
        {
            var dd = _context.Rooms.Where(x => x.Roomtype == "single").ToList();
            return View (dd);
        }
        public IActionResult DoubleRoom(string val)
        {
            var dd = _context.Rooms.Where(x => x.Roomtype == "Double").ToList();
            return View(dd);
        }

    }
}
