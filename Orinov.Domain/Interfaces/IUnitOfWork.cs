namespace Orinov.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAnnouncementInterface Announcements { get; }

        void Complete();
    }
}
