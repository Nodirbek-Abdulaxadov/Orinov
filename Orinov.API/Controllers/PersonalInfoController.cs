using Microsoft.AspNetCore.Mvc;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInfoController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PersonalInfoController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: api/<AnnouncementController>
        [HttpGet]
        public async Task<IEnumerable<PersonalInformation>> Get() => await unitOfWork.PersonalInformations.GetAll();

        // GET api/<AnnouncementController>/5
        [HttpGet("{id}")]
        public async Task<PersonalInformation> Get(int id) => await unitOfWork.PersonalInformations.Get(id);
    }
}
