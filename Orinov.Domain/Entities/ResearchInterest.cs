namespace Orinov.Domain.Entities
{
    public class ResearchInterest
    {
        public int Id { get; set; }
        public string NameEn { get; set; } = null!;
        public string NameUz { get; set; } = null!;
        public string NameRu { get; set; } = null!;
        public string TitleEn { get; set; } = null!;
        public string TitleUz { get; set; } = null!;
        public string TitleRu { get; set; } = null!;
        public int CVModelId { get; set; }
    }
}
