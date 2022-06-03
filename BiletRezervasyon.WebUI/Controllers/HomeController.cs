using BiletRezervasyon.Business.Abstract;
using BiletRezervasyon.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

using System.Linq;
using System.Threading.Tasks;

namespace BiletRezervasyon.WebUI.Controllers
{

    public class HomeController : Controller
    {
        private ICityService _cityService;
        private IRouteService _routeService;
        public HomeController(ICityService cityService, IRouteService routeService)
        {
            _cityService = cityService;
            _routeService = routeService;
        }
        public IActionResult Index()
        {
            return View(_cityService.GetAll());
        }


    }
}