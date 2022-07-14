using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Orinov.Domain.Interfaces;

namespace Orinov.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AnnouncementController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet, Route("getall")]
        public async Task<IActionResult> Get()
        {
            return Ok(await unitOfWork.Announcements.GetAll());
        }
    }
}
