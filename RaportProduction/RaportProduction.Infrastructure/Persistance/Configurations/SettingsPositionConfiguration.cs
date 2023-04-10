using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaportProduction.Domain.Entities;

namespace RaportProduction.Infrastructure.Persistance.Configurations
{
    public class SettingsPositionConfiguration : IEntityTypeConfiguration<SettingPosition>
    {
        public void Configure(EntityTypeBuilder<SettingPosition> builder)
        {
            builder.ToTable("SettingsPositions");

            builder.Property(x => x.Key)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Value)
                .HasMaxLength(1000);

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .HasOne(x => x.Settings)
                .WithMany(x => x.Positions)
                .HasForeignKey(x => x.SettingsId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
