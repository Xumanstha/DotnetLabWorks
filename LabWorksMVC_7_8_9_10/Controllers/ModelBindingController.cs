using LabWorksMVC_7_8_9_10.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabWorksMVC_7_8_9_10.Controllers
{
    public class ModelBindingController : Controller
    {
        // GET: /ModelBinding/Index
        public IActionResult Index()
        {
            return View(new Person());
        }

        // POST: /ModelBinding/Create
        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (!ModelState.IsValid)
            {
                // Validation failed — return to the same form
                // so the user sees their entered data + error messages
                return View("Index", person);
            }

            return View("Result", person);
        }
    }
}
