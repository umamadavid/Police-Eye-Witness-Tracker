using Police_Eye_Witness_Tracker.Models;
using Microsoft.EntityFrameworkCore;

namespace Police_Eye_Witness_Tracker.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<EyeWitnessReport> EyeWitnessReports { get; set; }

    }
}