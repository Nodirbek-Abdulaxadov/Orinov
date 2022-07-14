using Orinov.Data.Context;
using Orinov.Domain.Entities;
using Orinov.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orinov.Data.Repositories
{
    public class AnnouncementRepository : RepositoryBase<Announcement>, IAnnouncementInterface
    {
        public AnnouncementRepository(OrinovDbContext context) : base(context)
        {
        }
    }
}
