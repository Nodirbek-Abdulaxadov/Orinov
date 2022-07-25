using Microsoft.AspNetCore.Mvc;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicationController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public PublicationController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: api/<PublicationController>
        [HttpGet]
        public async Task<IEnumerable<Publication>> Get() => await unitOfWork.Publications.GetAll();

        // GET api/<PublicationController>/5
        [HttpGet("{id}")]
        public async Task<Publication> Get(int id) => await unitOfWork.Publications.Get(id);
    }
}
