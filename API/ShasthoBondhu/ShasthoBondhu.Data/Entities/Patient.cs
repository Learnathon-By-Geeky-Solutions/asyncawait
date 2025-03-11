namespace ShasthoBondhu.Data.Entities
{
    public class Patient
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Gender { get; set; }

        public required DateTime DateOfBirth { get; set; }

        public byte[]? Image { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? InsuranceDetails { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<Nominee>? Nominees { get; set; }

        #endregion
    }
}
