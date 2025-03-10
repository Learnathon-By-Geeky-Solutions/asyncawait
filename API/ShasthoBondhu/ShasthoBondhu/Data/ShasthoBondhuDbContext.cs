using Microsoft.EntityFrameworkCore;
using ShasthoBondhu.Models.Domain;

namespace ShasthoBondhu.Data
{
    public class ShasthoBondhuDbContext : DbContext
    {
        public ShasthoBondhuDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
