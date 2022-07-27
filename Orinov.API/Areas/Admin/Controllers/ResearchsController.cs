using Microsoft.AspNetCore.Mvc;

namespace Orinov.API.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ResearchsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
