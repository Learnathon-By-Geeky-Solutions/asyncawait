namespace ShasthoBondhu.Data.Entities
{
    public class DoctorHospital
    {
        public int Id { get; set; }

        public Guid DoctorId { get; set; }

        public Guid HospitalId { get; set; }

        public DateTime? AffiliationStartDate { get; set; }

        public DateTime? AffiliationEndDate { get; set; }

        #region Navigation properties

        public required Doctor Doctor { get; set; }

        public required Hospital Hospital { get; set; }

        public List<DoctorVisitingSchedules>? VisitingSchedules { get; set; }

        #endregion
    }
}
