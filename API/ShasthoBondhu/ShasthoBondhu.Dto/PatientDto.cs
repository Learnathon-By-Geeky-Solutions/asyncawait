namespace ShasthoBondhu.Dto
{
    public class PatientDto
    {
        public required string Name { get; set; }

        public required string Gender { get; set; }

        public required DateOnly DateOfBirth { get; set; }

        public byte[]? Image { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? InsuranceDetails { get; set; }
    }
}
