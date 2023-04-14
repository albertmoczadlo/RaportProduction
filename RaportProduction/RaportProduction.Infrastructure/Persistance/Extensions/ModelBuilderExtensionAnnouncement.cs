using Microsoft.EntityFrameworkCore;
using RaportProduction.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaportProduction.Infrastructure.Persistance.Extensions;

static class ModelBuilderExtensionAnnouncement
{
    public static void SeedAnnouncement(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Announcement>().HasData(
            new Announcement
            {
                Id = 1,
                Date = new DateTime(2022,11,21),
                Description = "Kod testowy- ogłoszenie"
            },
            new Announcement
            {
                Id = 2,
                Date = new DateTime(2022,01,02),
                Description = "Kod testowy 2- ogłoszenie"
            },
            new Announcement
            {
                Id = 3,
                Date = new DateTime(2022,09,05),
                Description = "Kod testowy 3- ogłoszenie"
            },
            new Announcement
            {
                Id = 4,
                Date = new DateTime(2022,10,21),
                Description = "Kod testowy 4- ogłoszenie"
            },
            new Announcement
            {
                Id = 5,
                Date = new DateTime(2022,12,26),
                Description = "Kod testowy 5- ogłoszenie"
            }
            );
    }
}
