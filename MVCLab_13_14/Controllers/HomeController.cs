using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCLab_13_14.Models;

namespace MVCLab_13_14.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // ===================== 1. SESSION =====================

        [HttpGet]
        public IActionResult SessionForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SessionForm(string name, string email)
        {
            HttpContext.Session.SetString("UserName", name ?? string.Empty);
            HttpContext.Session.SetString("UserEmail", email ?? string.Empty);

            return RedirectToAction("SessionDisplay");
        }

        [HttpGet]
        public IActionResult SessionDisplay()
        {
            ViewBag.Name = HttpContext.Session.GetString("UserName");
            ViewBag.Email = HttpContext.Session.GetString("UserEmail");
            return View();
        }

        public IActionResult ClearSession()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SessionDisplay");
        }

        // ===================== 2. TEMPDATA =====================

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(string employeeName)
        {
            TempData["Message"] = $"Employee '{employeeName}' added successfully!";
            return RedirectToAction("EmployeeList");
        }

        [HttpGet]
        public IActionResult EmployeeList()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EmployeeListAgain()
        {
            return View("EmployeeList");
        }

        // ===================== 3. COOKIES =====================

        [HttpGet]
        public IActionResult CookieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CookieForm(string theme)
        {
            var options = new CookieOptions
            {
                Expires = DateTimeOffset.Now.AddDays(1),
                HttpOnly = false,
                IsEssential = true
            };

            Response.Cookies.Append("ThemePreference", theme ?? "Light", options);

            return RedirectToAction("CookieDisplay");
        }

        [HttpGet]
        public IActionResult CookieDisplay()
        {
            string theme = Request.Cookies["ThemePreference"] ?? "Light";
            ViewBag.Theme = theme;
            return View();
        }

        public IActionResult DeleteCookie()
        {
            Response.Cookies.Delete("ThemePreference");
            return RedirectToAction("CookieDisplay");
        }
    }
}
