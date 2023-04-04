

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaportProduction.Domain.Entities;

namespace RaportProduction.Infrastructure.Persistance.Configurations;

public class SettingsConfiguration : IEntityTypeConfiguration<Settings>
{
    public void Configure(EntityTypeBuilder<Settings> builder)
    {
        builder.ToTable("Settings");

        builder.Property(x => x.Description)
            .IsRequired()
            .HasMaxLength(200);
    }
}
