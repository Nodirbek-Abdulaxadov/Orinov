using Orinov.Data.Context;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class PublicationRepository : RepositoryBase<Publication>, IPublicationInterface
    {
        public PublicationRepository(OrinovDbContext context) : base(context)
        {
        }
    }
}
