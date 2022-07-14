namespace Orinov.Domain.Entities
{
    public class EducationalBackground
    {
        public int Id { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public string DegreeEn { get; set; } = null!;
        public string DegreeUz { get; set; } = null!;
        public string DegreeRu { get; set; } = null!;
        public string FieldOfResearchEn { get; set; } = null!;
        public string FieldOfResearchUz { get; set; } = null!;
        public string FieldOfResearchRu { get; set; } = null!;
        public string ThesisEn { get; set; } = null!;
        public string ThesisUz { get; set; } = null!;
        public string ThesisRu { get; set; } = null!;
        public string SupervisorEn { get; set; } = null!;
        public string SupervisorUz { get; set; } = null!;
        public string SupervisorRu { get; set; } = null!;

        public int CVModelId { get; set; }
    }
}
