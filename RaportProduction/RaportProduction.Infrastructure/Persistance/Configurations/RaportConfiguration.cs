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


        }
    }
}
