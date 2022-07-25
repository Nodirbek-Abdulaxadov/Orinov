namespace Orinov.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementInterface Announcements { get; }
        IPublicationInterface Publications { get; }
        ICVInterface CVInterface { get; }
        void Complete();
    }
}
