namespace ShasthoBondhu.Data.Entities
{
    public class DoctorReceptionist
    {
        public int Id { get; set; }

        public Guid DoctorId { get; set; }

        public Guid ReceptionistId { get; set; }

        public DateTime? AssignmentStartDate { get; set; }

        public DateTime? AssignmentEndDate { get; set; }

        #region Navigation properties
        public required Doctor Doctor { get; set; }

        public required Receptionist Receptionist { get; set; }

        #endregion
    }
}
