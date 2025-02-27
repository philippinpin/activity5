using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string name, string email, string message)
        {
            if (ModelState.IsValid)
            {
                // Handle form submission (e.g., send email, save to database, etc.)
                return RedirectToAction("ThankYou");
            }
            return View("Index");
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
