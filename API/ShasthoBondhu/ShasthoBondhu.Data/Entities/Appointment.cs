using ShasthoBondhu.Data.Entities.AuditLog;

namespace ShasthoBondhu.Data.Entities
{
    public class Appointment : AuditableEntity
    {
        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public int? HospitalId { get; set; }

        public string? Status { get; set; }

        public string? ReasonForVisit { get; set; }

        public DateTime AppointmentDateTime { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Patient Patient { get; set; }

        public Hospital? Hospital { get; set; }

        #endregion
    }
}
