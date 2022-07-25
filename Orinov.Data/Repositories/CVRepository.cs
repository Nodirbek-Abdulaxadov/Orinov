using Orinov.Data.Context;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class CVRepository : RepositoryBase<Cvmodel>, ICVInterface
    {
        public CVRepository(OrinovDbContext context) : base(context)
        {
        }
    }
}
