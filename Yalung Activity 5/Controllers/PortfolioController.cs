using Microsoft.AspNetCore.Mvc;

namespace Yalung_Activity_5.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
