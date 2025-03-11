namespace ShasthoBondhu.Data.Entities
{
    public class DoctorVisitingSchedules
    {
        public int Id { get; set; }

        public Guid DoctorId { get; set; }

        public Guid HospitalId { get; set; }

        public int DoctorHospitalId { get; set; }

        public required List<DayOfWeek> Days { get; set; }

        public TimeOnly StartTime { get; set; }

        public TimeOnly EndTime { get; set; }

        #region Navigation properties

        public required DoctorHospital DoctorHospital { get; set; }

        #endregion
    }
}
