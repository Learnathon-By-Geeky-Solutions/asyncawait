using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;
using ShasthoBondhu.Data.Entities.Enums;

namespace ShasthoBondhu.Data.Entities
{
    public class Appointment : AuditableEntity
    {
        [Required]
        public int PatientId { get; set; }

        [Required]
        public int DoctorId { get; set; }

        public int? HospitalId { get; set; }

        public AppointmentStatus? Status { get; set; }

        [MaxLength(500)]
        public string? ReasonForVisit { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime AppointmentDateTime { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Patient Patient { get; set; }

        public Hospital? Hospital { get; set; }

        #endregion
    }
}
