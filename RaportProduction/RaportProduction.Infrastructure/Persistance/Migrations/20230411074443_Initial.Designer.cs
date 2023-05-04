﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaportProduction.Infrastructure.Persistance;

#nullable disable

namespace RaportProduction.Infrastructure.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230411074443_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RaportProduction.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Announcement", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kod testowy- ogłoszenie"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kod testowy 2- ogłoszenie"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kod testowy 3- ogłoszenie"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kod testowy 4- ogłoszenie"
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Kod testowy 5- ogłoszenie"
                        });
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("RegisterDataTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("DayOfDismissal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DayOfEmployment")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WebsiteRaw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Employees", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.EmployeeEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFullDay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("EmployeeEvents", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.File", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<long>("Bytes")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("Files", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.ProductionTime", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndProductionTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartProductionTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductionTimes", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Raport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Comments")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductionTimeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasPrecision(9)
                        .HasColumnType("int");

                    b.Property<int>("TankId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("ProductionTimeId")
                        .IsUnique();

                    b.HasIndex("TankId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Raports", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Settings", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "e-mail",
                            Order = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ogólne",
                            Order = 1
                        });
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.SettingsPosition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int>("SettingsId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId");

                    b.ToTable("SettingsPositions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Host",
                            Key = "HostSmtp",
                            Order = 1,
                            SettingsId = 1,
                            Type = 0,
                            Value = "smtp.gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Port",
                            Key = "Port",
                            Order = 2,
                            SettingsId = 1,
                            Type = 2,
                            Value = "587"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Adres e-mail nadawcy",
                            Key = "SenderEmail",
                            Order = 3,
                            SettingsId = 1,
                            Type = 0,
                            Value = " "
                        },
                        new
                        {
                            Id = 4,
                            Description = "Hasło",
                            Key = "SenderEmailPassword",
                            Order = 4,
                            SettingsId = 1,
                            Type = 4,
                            Value = ""
                        },
                        new
                        {
                            Id = 5,
                            Description = "Nazwa nadawcy",
                            Key = "SenderName",
                            Order = 5,
                            SettingsId = 1,
                            Type = 0,
                            Value = "Jan Kowalski"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Login nadawcy",
                            Key = "SenderLogin",
                            Order = 6,
                            SettingsId = 1,
                            Type = 0,
                            Value = " "
                        },
                        new
                        {
                            Id = 7,
                            Description = "Czy wyświetlać baner na stronie głównej?",
                            Key = "BannerVisible",
                            Order = 1,
                            SettingsId = 2,
                            Type = 1,
                            Value = "True"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Kolor footera strony głónej",
                            Key = "FooterColor",
                            Order = 2,
                            SettingsId = 2,
                            Type = 5,
                            Value = "#dc3545"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Adres administratora",
                            Key = "AdminEmail",
                            Order = 3,
                            SettingsId = 2,
                            Type = 0,
                            Value = "testappjedi@gmail.com"
                        });
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Tank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberTanks")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tanks", (string)null);
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Address", b =>
                {
                    b.HasOne("RaportProduction.Domain.Entities.ApplicationUser", "User")
                        .WithOne("Address")
                        .HasForeignKey("RaportProduction.Domain.Entities.Address", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Employee", b =>
                {
                    b.HasOne("RaportProduction.Domain.Entities.ApplicationUser", "User")
                        .WithOne("Employee")
                        .HasForeignKey("RaportProduction.Domain.Entities.Employee", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.EmployeeEvent", b =>
                {
                    b.HasOne("RaportProduction.Domain.Entities.ApplicationUser", "User")
                        .WithMany("EmployeeEvents")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Raport", b =>
                {
                    b.HasOne("RaportProduction.Domain.Entities.Product", "Product")
                        .WithOne("Raport")
                        .HasForeignKey("RaportProduction.Domain.Entities.Raport", "ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RaportProduction.Domain.Entities.ProductionTime", "ProductionTime")
                        .WithOne("Raport")
                        .HasForeignKey("RaportProduction.Domain.Entities.Raport", "ProductionTimeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RaportProduction.Domain.Entities.Tank", "Tank")
                        .WithOne("Raport")
                        .HasForeignKey("RaportProduction.Domain.Entities.Raport", "TankId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RaportProduction.Domain.Entities.ApplicationUser", "User")
                        .WithMany("Raports")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Product");

                    b.Navigation("ProductionTime");

                    b.Navigation("Tank");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.SettingsPosition", b =>
                {
                    b.HasOne("RaportProduction.Domain.Entities.Settings", "Settings")
                        .WithMany("Positions")
                        .HasForeignKey("SettingsId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Employee");

                    b.Navigation("EmployeeEvents");

                    b.Navigation("Raports");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Product", b =>
                {
                    b.Navigation("Raport");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.ProductionTime", b =>
                {
                    b.Navigation("Raport");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Settings", b =>
                {
                    b.Navigation("Positions");
                });

            modelBuilder.Entity("RaportProduction.Domain.Entities.Tank", b =>
                {
                    b.Navigation("Raport");
                });
#pragma warning restore 612, 618
        }
    }
}
