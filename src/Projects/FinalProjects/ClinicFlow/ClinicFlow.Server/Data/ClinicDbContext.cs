using ClinicFlow.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClinicFlow.Server.Data
{
    public class ClinicDbContext : IdentityDbContext<ApplicationUser>
    {
        public ClinicDbContext(DbContextOptions<ClinicDbContext> options) : base(options) { }

        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Appointment> Appointments => Set<Appointment>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Name = "Dr. Alice", Specialty = "General", Contact = "1234567890" },
                new Doctor { Id = 2, Name = "Dr. Bob", Specialty = "Dermatology", Contact = "9876543210" }
            );

            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, Name = "Jane Doe", Age = 29, Contact = "555-0100", Gender = "Female", Address = "123 Main St" }
            );
        }
    }
}
