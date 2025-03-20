using ShasthoBondhu.Data.Entities.AuditLog;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorHospital : AuditableEntity
    {
        public int DoctorId { get; set; }

        public int HospitalId { get; set; }

        public DateTime? AffiliationStartDate { get; set; }

        public DateTime? AffiliationEndDate { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Hospital Hospital { get; set; }

        public List<DoctorVisitingSchedules>? VisitingSchedules { get; set; }

        #endregion
    }
}
