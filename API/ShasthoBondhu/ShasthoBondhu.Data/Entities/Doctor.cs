using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class Doctor : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        [Phone]
        [MaxLength(15)]
        public string? Phone { get; set; }

        [EmailAddress]
        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(100)]
        public string? Specialization { get; set; }

        [MaxLength(100)]
        public string? Degree { get; set; }

        [MaxLength(100)]
        public string? Designation { get; set; }

        [MaxLength(500)]
        public string? Details { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<DoctorHospital>? DoctorHospitals { get; set; }

        public List<DoctorReceptionist>? DoctorReceptionists { get; set; }

        #endregion
    }
}
