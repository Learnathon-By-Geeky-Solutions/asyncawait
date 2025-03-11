using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data.Entities;

namespace ShasthoBondhu.Data
{
    public interface IShasthoBondhuDbContext
    {
        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Hospital> Hospitals { get; set; }

        public DbSet<Receptionist> Receptionists { get; set; }

        public DbSet<Nominee> Nominees { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<DoctorHospital> DoctorHospitals { get; set; }

        public DbSet<DoctorReceptionist> DoctorReceptionists { get; set; }

        public DbSet<DoctorVisitingSchedules> DoctorVisitingSchedules { get; set; }

        Task<int> SaveChangesAsync();
    }
}
