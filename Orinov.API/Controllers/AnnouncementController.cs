using Microsoft.AspNetCore.Mvc;
using Orinov.Domain.Entities;
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

        // GET: api/<AnnouncementController>
        [HttpGet]
        public async Task<IEnumerable<Announcement>> Get() => await unitOfWork.Announcements.GetAll();

        // GET api/<AnnouncementController>/5
        [HttpGet("{id}")]
        public async Task<Announcement> Get(int id) => await unitOfWork.Announcements.Get(id);
    }
}
