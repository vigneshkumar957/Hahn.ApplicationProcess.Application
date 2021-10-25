using Hahn.ApplicationProcess.July2021.Core;
using Microsoft.EntityFrameworkCore;

namespace Hahn.ApplicationProcess.July2021.Data
{
    public class ApplicantContext : DbContext
    {
        public ApplicantContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Applicant> Applicants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("InMemoryProvider");
        }                                                                                                                                               
    }
}
