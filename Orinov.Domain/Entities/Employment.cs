namespace Orinov.Domain.Entities
{
    public class Employment
    {
        public int Id { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string PositionUz { get; set; } = null!;
        public string PositionEn { get; set; } = null!;
        public string PositionRu { get; set; } = null!;
        public string CompanyEn { get; set; } = null!;
        public string CompanyUz { get; set; } = null!;
        public string CompanyRu { get; set; } = null!;
        public int CVModelId { get; set; }
    }
}
