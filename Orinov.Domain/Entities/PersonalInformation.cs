namespace Orinov.Domain.Entities
{
    public class PersonalInformation
    {
        public int Id { get; set; }
        public string DateOfBirthEn { get; set; } = null!;
        public string DateOfBirthUz { get; set; } = null!;
        public string DateOfBirthRu { get; set; } = null!;
        public string GenderEn { get; set; } = null!;
        public string GenderUz { get; set; } = null!;
        public string GenderRu { get; set; } = null!;
        public string NationalityEn { get; set; } = null!;
        public string NationalityUz { get; set; } = null!;
        public string NationalityRu { get; set; } = null!;
        public string AddressEn { get; set; } = null!;
        public string AddressUz { get; set; } = null!;
        public string AddressRu { get; set; } = null!;
        public string Mobile { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CVModelId { get; set; }
    }
}
