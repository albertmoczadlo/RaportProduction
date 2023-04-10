using Microsoft.EntityFrameworkCore;
using RaportProduction.Domain.Entities;
using File = RaportProduction.Domain.Entities.File;

namespace RaportProduction.Application.Common.Interfaces;

public interface IApplicationDbContext : IDisposable
{
    DbSet<Address> Addresses { get; set; }
    DbSet<Announcement> Announcements { get; set; }
    DbSet<ApplicationUser> Users { get; set; }
    DbSet<Employee> Employees { get; set; }
    DbSet<EmployeeEvent> EmployeeEvents { get; set; }
    DbSet<File> Files { get; set; }
    DbSet<Product> Products { get; set; }
    DbSet<ProductionTime> ProductionTimes { get; set; }
    DbSet<Raport> Raports { get; set; }
    DbSet<SettingsPosition> SettingPositions { get; set; }
    DbSet<Settings> Settings { get; set; }
    DbSet<Tank> Tanks { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken=default);
}
