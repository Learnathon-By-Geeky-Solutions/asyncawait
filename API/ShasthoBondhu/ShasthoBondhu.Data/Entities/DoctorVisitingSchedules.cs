using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorVisitingSchedules : AuditableEntity
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int HospitalId { get; set; }

        [Required]
        public int DoctorHospitalId { get; set; }

        [Required]
        public required List<DayOfWeek> Days { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        #region Navigation properties

        public required DoctorHospital DoctorHospital { get; set; }

        #endregion
    }
}
