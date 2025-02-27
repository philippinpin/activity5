using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
