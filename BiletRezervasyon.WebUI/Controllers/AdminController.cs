using BiletRezervasyon.Business.Abstract;
using BiletRezervasyon.Entities;
using BiletRezervasyon.WebUI.Helper;
using BiletRezervasyon.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BiletRezervasyon.WebUI.Controllers
{
    [UserFilter]
    public class AdminController : Controller
    {
        private ITicketService _ticketService;
        private IRouteService _routeService;
        private IBusService _busService;
        private ICityService _cityService;
        public AdminController(IRouteService routeService, ITicketService ticketService, IBusService busService, ICityService cityService)
        {
            _routeService = routeService;
            _ticketService = ticketService;
            _busService = busService;
            _cityService = cityService;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAdminTickets()
        {
            return View(_ticketService.GetAll());
        }

        public IActionResult DeleteAdminTicket(int ticketId)
        {
            var entity = _ticketService.GetById(ticketId);
            _ticketService.Delete(entity);
            return RedirectToAction("GetAdminTickets");
        }
        public IActionResult GetAdminBuses()
        {
            return View(_busService.GetAll());
        }
        public IActionResult CreateAdminBus()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAdminBus(BusModel model)   
        {
            if (ModelState.IsValid)
            {
                var bus = new Bus()
                {
                    BusDriverFullName = model.BusDriverFullName,
                    BusPlaque = model.BusPlaque,
                    BusSeatCapacity = model.BusSeatCapacity
                };
                _busService.Create(bus);
                return RedirectToAction("GetAdminBuses","Admin"); 
            }
            return View(model);
            
        }
        public IActionResult DeleteAdminBuses(int busId) 
        {
            var entity = _busService.GetById(busId);
            _busService.Delete(entity);
            return RedirectToAction("GetAdminBuses");
        } 
          
        public IActionResult GetAdminRoutes()
        {
            _busService.GetAll();
            return View(_routeService.GetAll());
        }
        public IActionResult CreateAdminRoute()
        {
            ViewBag.busId = _busService.GetAll();
            ViewBag.Cities = _cityService.GetAll();
            return View();
        }
        [HttpPost] 
        public IActionResult CreateAdminRoute(Route route)
        {
            
            _routeService.Create(route);
            return RedirectToAction("GetAdminRoutes");
        }
        public IActionResult DeleteAdminRoute(int routeId) 
        {
            
            var entity = _routeService.GetById(routeId);
            _routeService.Delete(entity);
            return RedirectToAction("GetAdminRoutes");
        }

        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }

    }
}
