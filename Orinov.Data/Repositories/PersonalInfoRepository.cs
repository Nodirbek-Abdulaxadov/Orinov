using Orinov.Data.Context;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class PersonalInfoRepository : RepositoryBase<PersonalInformation>, IPersonalInfoInterface
    {
        public PersonalInfoRepository(OrinovDbContext context) : base(context)
        {
        }
    }
}
