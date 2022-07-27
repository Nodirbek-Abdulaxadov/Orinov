namespace Orinov.Domain.Entities
{
    public class Event
    {
        public Event()
        {
            Files = new HashSet<FileModel>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? SpeakerEn { get; set; }
        public string? SpeakerUz { get; set; }
        public string? SpeakerRu { get; set; }
        public string TitleEn { get; set; } = null!;
        public string TitleUz { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string PlaceEn { get; set; } = null!;
        public string PlaceUz { get; set; } = null!;
        public string PlaceRu { get; set; } = null!;

        public ICollection<FileModel> Files { get; set; }
    }
}
