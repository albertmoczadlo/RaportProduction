using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RaportProduction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Infrastructure.Persistance.Configurations
{
    public class RaportConfiguration : IEntityTypeConfiguration<Raport>
    {
        public void Configure(EntityTypeBuilder<Raport> builder)
        {
            builder.ToTable("Raports");

            builder
                 .HasOne(t => t.Tank)
                 .WithOne(u => u.Raport)
                 .HasForeignKey<Raport>(x=>x.TankId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p=>p.Product)
                .WithOne(r=>r.Raport)
                .HasForeignKey<Raport>(r=>r.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.ProductionTime)
                .WithOne(r => r.Raport)
                .HasForeignKey<Raport>(r => r.ProductionTimeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(q => q.Quantity)
                .HasPrecision(9, 0)
                .IsRequired(false);

            builder
                .Property(u=>u.Comments)
                .HasMaxLength(600)
                .IsRequired(false);

        }
    }
}
