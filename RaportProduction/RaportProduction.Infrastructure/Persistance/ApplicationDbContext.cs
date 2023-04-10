using Microsoft.EntityFrameworkCore;
using RaportProduction.Domain.Entities;
using System.Reflection;
using File = RaportProduction.Domain.Entities.File;

namespace RaportProduction.Infrastructure.Persistance;

public class ApplicationDbContext: DbContext
{

    public DbSet<Address> Addresses { get; set; }
    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmployeeEvent> EmployeeEvents { get; set; }
    public DbSet<File> Files { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductionTime> ProductionTimes { get; set; }
    public DbSet<Raport> Raports { get; set; }
    public DbSet<SettingPosition> SettingPositions { get; set; }
    public DbSet<Settings> Settings { get; set; }
    public DbSet<Tank> Tanks { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
