using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaportProduction.Domain.Entities;

namespace RaportProduction.Infrastructure.Persistance.Configurations;

public class ProductionTimeConfiguration : IEntityTypeConfiguration<ProductionTime>
{
    public void Configure(EntityTypeBuilder<ProductionTime> builder)
    {
        builder.ToTable("ProductionTimes");

        builder
            .Property(e=>e.EndProductionTime)
            .IsRequired(false);
    }
}
