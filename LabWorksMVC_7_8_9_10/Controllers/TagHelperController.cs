using LabWorksMVC_7_8_9_10.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LabWorksMVC_7_8_9_10.Controllers
{
    public class TagHelperController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
            }

            return View(model);
        }
    }
}
