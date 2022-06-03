using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiletRezervasyon.WebUI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            string user = "admin";
            string pass = "admin";
            if (user == userName && pass == password)
            {
                HttpContext.Session.SetString("user", user);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
