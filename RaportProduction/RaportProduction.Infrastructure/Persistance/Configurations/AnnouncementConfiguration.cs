using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaportProduction.Domain.Entities;

namespace RaportProduction.Infrastructure.Persistance.Configurations;

public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
{
    public void Configure(EntityTypeBuilder<Announcement> builder)
    {
        builder.ToTable("Announcement");

        builder.Property(x => x.Description)
           .IsRequired();
    }
}
