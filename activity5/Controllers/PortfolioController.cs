using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
