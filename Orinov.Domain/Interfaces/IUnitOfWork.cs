namespace Orinov.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementInterface Announcements { get; }
        IPublicationInterface Publications { get; }
        IPersonalInfoInterface PersonalInformations { get; }
        IEventInterface Events { get; }
        void Complete();
    }
}
