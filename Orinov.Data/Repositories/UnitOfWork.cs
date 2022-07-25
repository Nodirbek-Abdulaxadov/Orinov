using Orinov.Data.Context;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrinovDbContext context;

        public UnitOfWork( OrinovDbContext context,
                           IAnnouncementInterface announcement,
                           IPublicationInterface publicationInterface,
                           ICVInterface cvInterface)
        {
            this.context = context;
            Announcements = announcement;
            Publications = publicationInterface;
            CVInterface = cvInterface;
        }
        public IAnnouncementInterface Announcements { get; }

        public IPublicationInterface Publications { get; }

        public ICVInterface CVInterface {get; }

        public void Complete()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
