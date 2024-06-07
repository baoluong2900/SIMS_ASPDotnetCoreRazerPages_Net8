using Microsoft.EntityFrameworkCore;
using StudentInformationManagementWebsite.Models.Domain;

namespace StudentInformationManagementWebsite.Data
{
    public class SimsDbContext : DbContext
    {
        public SimsDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
