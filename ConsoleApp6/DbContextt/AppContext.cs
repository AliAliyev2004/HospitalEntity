using ConsoleApp6.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp6.DbContextt;

public class AppContext:DbContext
{
    public DbSet<Department> Departments { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=ALI\\SQLEXPRESS;Initial Catalog=DBB;Trusted_Connection=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>()
            .HasIndex(a => new { a.DoctorId, a.AppointmentDate, a.TimeSlot })
            .IsUnique();
    }
}
