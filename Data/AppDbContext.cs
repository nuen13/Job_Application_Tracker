using Microsoft.EntityFrameworkCore;
using Job_Application_Tracker.Models;
using Job_Application_Tracker.Services;

namespace Job_Application_Tracker.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<JobApplication> JobApplications { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
