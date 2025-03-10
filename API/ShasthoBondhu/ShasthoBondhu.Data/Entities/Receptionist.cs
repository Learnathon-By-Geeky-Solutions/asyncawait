namespace ShasthoBondhu.Data.Entities
{
    public class Receptionist
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Email { get; set; }

        #region Navigation properties

        public List<DoctorReceptionist>? DoctorReceptionists { get; set; }

        #endregion
    }
}
