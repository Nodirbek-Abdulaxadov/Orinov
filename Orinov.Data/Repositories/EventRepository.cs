using Orinov.Data.Context;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventInterface
    {
        public EventRepository(OrinovDbContext context) : base(context)
        {
        }
    }
}
