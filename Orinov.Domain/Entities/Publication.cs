namespace Orinov.Domain.Entities
{
    public class Publication
    {
        public Publication()
        {
            Files = new HashSet<FileModel>();
        }

        public int Id { get; set; }
        public int PublishedYear { get; set; }
        public string AuthorsEn { get; set; } = null!;
        public string AuthorsUz { get; set; } = null!;
        public string AuthorsRu { get; set; } = null!;
        public string ThemeEn { get; set; } = null!;
        public string ThemeUz { get; set; } = null!;
        public string ThemeRu { get; set; } = null!;
        public string AdditionalEn { get; set; } = null!;
        public string AdditionalUz { get; set; } = null!;
        public string AdditionalRu { get; set; } = null!;
        public string Link { get; set; } = null!;
        public bool IsBook { get; set; }
        public int CVModelId { get; set; }
        public ICollection<FileModel> Files { get; set; }
    }
}
