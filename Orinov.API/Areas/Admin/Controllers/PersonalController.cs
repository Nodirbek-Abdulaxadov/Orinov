using Microsoft.AspNetCore.Mvc;

namespace Orinov.API.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
