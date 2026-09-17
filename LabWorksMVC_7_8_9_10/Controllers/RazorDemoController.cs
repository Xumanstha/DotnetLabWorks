using Microsoft.AspNetCore.Mvc;

namespace LabWorksMVC_7_8_9_10.Controllers
{
    public class RazorDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to Razor Demo!";

            ViewData["Numbers"] = new List<int> { 10, 20, 30, 40, 50 };

            return View();
        }
    }
}
