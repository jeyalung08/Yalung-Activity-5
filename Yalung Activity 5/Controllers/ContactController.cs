using Microsoft.AspNetCore.Mvc;

namespace Yalung_Activity_5.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
