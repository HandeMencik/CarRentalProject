using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
