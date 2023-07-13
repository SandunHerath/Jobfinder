using JobFinder.Models;
using JobFinder.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.Context
{
    public class AppDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LAPTOP-T7GJ7910; Database=JobFinder;Trusted_Connection=True;Encrypt=False; User Id=sa; Password=1234";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Company>Companies { get; set; }    
        public DbSet<Job>Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .HasOne(job => job.Company)
                .WithMany(company => company.Jobs)
                .HasForeignKey(job => job.CompanyId);

            modelBuilder.Entity<Candidate>()
                .HasOne(candidate => candidate.Job)
                .WithMany(job => job.Candidates)
                .HasForeignKey(candidate => candidate.JobId);

            modelBuilder.Entity<Company>()
                .Property(company => company.Size)
                .HasConversion<string>();

            modelBuilder.Entity<Job>()
               .Property(job => job.Level)
               .HasConversion<string>();

            modelBuilder.Entity<Job>()
               .Property(job => job.JobType)
               .HasConversion<string>();

            modelBuilder.Entity<Company>().HasData(new Company[]
            {
                new Company{ID=1,Name="MIT",Size=CompanySize.Largeer,IsActive=true},
                new Company{ID=2,Name="HasthiyaIT",Size=CompanySize.Small,IsActive=true},
                new Company{ID=3,Name="Creative Software",Size=CompanySize.Large,IsActive=true},
                new Company{ID=4,Name="GTN",Size=CompanySize.Medium,IsActive=true}
            });
        }
    }
}
