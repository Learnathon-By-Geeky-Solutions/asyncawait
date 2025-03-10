namespace ShasthoBondhu.Data.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }

        public Guid PatientId { get; set; }

        public Guid DoctorId { get; set; }

        public Guid? HospitalId { get; set; }

        public string? Status { get; set; }

        public string? ReasonForVisit { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Patient Patient { get; set; }

        public Hospital? Hospital { get; set; }

        #endregion
    }
}
