namespace Orinov.Domain.Entities
{
    public class FileModel
    {
        public int Id { get; set; }
        public int FilePath { get; set; }
        public int? EventsId { get; set; }
        public int? PublicationsId { get; set; }
    }
}
