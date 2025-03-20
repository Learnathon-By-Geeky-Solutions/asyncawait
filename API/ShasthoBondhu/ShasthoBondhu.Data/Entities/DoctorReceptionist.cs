using ShasthoBondhu.Data.Entities.AuditLog;

namespace ShasthoBondhu.Data.Entities
{
    public class DoctorReceptionist : AuditableEntity
    {
        public int DoctorId { get; set; }

        public int ReceptionistId { get; set; }

        public int? HospitalId { get; set; }

        public DateTime? AssignmentStartDate { get; set; }

        public DateTime? AssignmentEndDate { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Receptionist Receptionist { get; set; }

        #endregion
    }
}
