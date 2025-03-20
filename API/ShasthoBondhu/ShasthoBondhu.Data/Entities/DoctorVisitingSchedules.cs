using ShasthoBondhu.Data.Entities.AuditLog;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorVisitingSchedules : AuditableEntity
    {
        public int DoctorId { get; set; }

        public int HospitalId { get; set; }

        public int DoctorHospitalId { get; set; }

        public required List<DayOfWeek> Days { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        #region Navigation properties

        public required DoctorHospital DoctorHospital { get; set; }

        #endregion
    }
}
