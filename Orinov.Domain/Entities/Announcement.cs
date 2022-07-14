namespace Orinov.Domain.Entities
{
    public class Announcement
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string TitleEn { get; set; } = null!;
        public string TitleUz { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public string PlaceEn { get; set; } = null!;
        public string PlaceUz { get; set; } = null!;
        public string PlaceRu { get; set; } = null!;
    }
}
