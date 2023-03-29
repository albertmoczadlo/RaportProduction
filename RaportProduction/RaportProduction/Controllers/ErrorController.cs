using Microsoft.AspNetCore.Mvc;

namespace ProductionManager.UI.Controllers
{
    public class ErrorController : Controller
    {
        [HttpGet("/Error")]
        public IActionResult Index()
        {
            return View("Error");
        }
    }
}
