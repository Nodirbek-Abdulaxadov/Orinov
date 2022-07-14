namespace Orinov.Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string NameEn { get; set; } = null!;
        public string NameUz { get; set; } = null!;
        public string NameRu { get; set; } = null!;
        public string DegreeEn { get; set; } = null!;
        public string DegreeUz { get; set; } = null!;
        public string DegreeRu { get; set; } = null!;
        public string? CommentEn { get; set; }
        public string? CommentUz { get; set; }
        public string? CommentRu { get; set; }
        public int CVModelId { get; set; }
    }
}
