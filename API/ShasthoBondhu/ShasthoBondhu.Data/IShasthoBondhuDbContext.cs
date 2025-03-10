using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Data.Entities;

namespace ShasthoBondhu.Data
{
    public interface IShasthoBondhuDbContext
    {
        public DbSet<Patient> Patients { get; set; }

        Task<int> SaveChangesAsync();
    }
}
