using Microsoft.AspNetCore.Mvc;
using Orinov.Domain.Interfaces;

namespace Orinov.API.Areas.Admin.Controllers
{
    [Area("admin")]
    public class EventsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public EventsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var list = await unitOfWork.Events.GetAll();
            return View(list);
        }
    }
}
