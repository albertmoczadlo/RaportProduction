using Microsoft.EntityFrameworkCore;
using RaportProduction.Domain.Entities;

namespace RaportProduction.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionSettings
{
    public static void SeedSettings(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Settings>().HasData(
            new Settings
            {
                Id = 1,
                Description = "e-mail",
                Order = 2
            },
            new Settings
            {
                Id = 2,
                Description = "Ogólne",
                Order = 1
            }
            );
    }
}
