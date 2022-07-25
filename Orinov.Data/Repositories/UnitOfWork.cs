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
                           IPersonalInfoInterface personalInfoInterface)
        {
            this.context = context;
            Announcements = announcement;
            Publications = publicationInterface;
            PersonalInformations = personalInfoInterface;
        }
        public IAnnouncementInterface Announcements { get; }

        public IPublicationInterface Publications { get; }

        public IPersonalInfoInterface PersonalInformations { get; }

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
