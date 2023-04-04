using RaportProduction.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RaportProduction.Infrastructure.Persistence.Configurations;

class EmployeeEventConfiguration : IEntityTypeConfiguration<EmployeeEvent>
{
    public void Configure(EntityTypeBuilder<EmployeeEvent> builder)
    {
        builder.ToTable("EmployeeEvents");

        builder.Property(x => x.UserId)
            .IsRequired();

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.EmployeeEvents)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
