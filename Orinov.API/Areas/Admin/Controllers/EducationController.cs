using Microsoft.AspNetCore.Mvc;

namespace Orinov.API.Areas.Admin.Controllers
{
    [Area("admin")]
    public class EducationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
