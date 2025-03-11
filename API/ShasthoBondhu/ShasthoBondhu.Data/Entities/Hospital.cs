namespace ShasthoBondhu.Data.Entities
{
    public class Hospital
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        public string? Location { get; set; }

        public List<string>? Phones { get; set; }

        public List<string>? Emails { get; set; }

        public string? Website { get; set; }

        public string? AdditionalInfo { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<DoctorHospital>? DoctorHospitals { get; set; }

        #endregion
    }
}
