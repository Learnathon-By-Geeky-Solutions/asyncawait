namespace ShasthoBondhu.Data.Entities
{
    public class Doctor
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        public string? Phone { get; set; }

        public string? Email { get; set; }

        public string? Specialization { get; set; }

        public string? Degree { get; set; }

        public string? Designation { get; set; }

        public string? Details { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<DoctorHospital>? DoctorHospitals { get; set; }

        public List<DoctorReceptionist>? DoctorReceptionists { get; set; }

        #endregion
    }
}
