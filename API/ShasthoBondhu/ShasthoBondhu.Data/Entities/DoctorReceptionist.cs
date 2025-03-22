using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorReceptionist : AuditableEntity
    {
        [Required]
        public int DoctorId { get; set; }

        [Required]
        public int ReceptionistId { get; set; }

        public int? HospitalId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? AssignmentStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? AssignmentEndDate { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Receptionist Receptionist { get; set; }

        #endregion
    }
}
