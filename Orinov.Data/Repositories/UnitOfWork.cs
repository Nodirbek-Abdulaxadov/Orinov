using Orinov.Data.Context;
using Orinov.Domain.Interfaces;

namespace Orinov.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OrinovDbContext context;

        public UnitOfWork( OrinovDbContext context,
                           IAnnouncementInterface announcement)
        {
            this.context = context;
            Announcements = announcement;
        }
        public IAnnouncementInterface Announcements { get; }

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
