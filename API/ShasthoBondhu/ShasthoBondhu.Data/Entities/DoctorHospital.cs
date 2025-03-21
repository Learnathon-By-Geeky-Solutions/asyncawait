using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorHospital : AuditableEntity
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int HospitalId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? AffiliationStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? AffiliationEndDate { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Hospital Hospital { get; set; }

        public List<DoctorVisitingSchedules>? VisitingSchedules { get; set; }

        #endregion
    }
}
