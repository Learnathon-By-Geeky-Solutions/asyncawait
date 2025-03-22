using ShasthoBondhu.Data.Entities.AuditLog;
using System.ComponentModel.DataAnnotations;

namespace ShasthoBondhu.Data.Entities
{
    public class Hospital : AuditableEntity
    {
        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        public byte[]? Image { get; set; }

        [MaxLength(200)]
        public string? Location { get; set; }

        public List<string>? Phones { get; set; }

        public List<string>? Emails { get; set; }

        [Url]
        [MaxLength(200)]
        public string? Website { get; set; }

        [MaxLength(500)]
        public string? AdditionalInfo { get; set; }

        #region Navigation properties

        public List<Appointment>? Appointments { get; set; }

        public List<DoctorHospital>? DoctorHospitals { get; set; }

        #endregion
    }
}
