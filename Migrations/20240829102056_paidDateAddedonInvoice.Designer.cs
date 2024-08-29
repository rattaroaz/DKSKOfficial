﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DKSKOfficial.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240829102056_paidDateAddedonInvoice")]
    partial class paidDateAddedonInvoice
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Companny", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ownner")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companny");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 A St.",
                            CellPhone = "123-456-7890",
                            City = "CityA",
                            Email = "ownerA@example.com",
                            Name = "Company A",
                            Ownner = "Owner A",
                            SpecialNote = "Note A",
                            Zip = "11111"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 B St.",
                            CellPhone = "987-654-3210",
                            City = "CityB",
                            Email = "ownerB@example.com",
                            Name = "Company B",
                            Ownner = "Owner B",
                            SpecialNote = "Note B",
                            Zip = "22222"
                        });
                });

            modelBuilder.Entity("Companny2Property", b =>
                {
                    b.Property<int>("CompannyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CompannyId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("Companny2Property");

                    b.HasData(
                        new
                        {
                            CompannyId = 1,
                            PropertiesId = 1
                        },
                        new
                        {
                            CompannyId = 1,
                            PropertiesId = 2
                        },
                        new
                        {
                            CompannyId = 2,
                            PropertiesId = 1
                        });
                });

            modelBuilder.Entity("Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContractorID")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PayrollPercent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SocailSecurityNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contractor");
                });

            modelBuilder.Entity("Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountCost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountPaid")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AnticipatedEndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CheckNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ContractorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DatePaid")
                        .HasColumnType("TEXT");

                    b.Property<string>("GateCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("JobDescriptionChoice")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LockBox")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Paid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PropertyAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SizeBathroom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SizeBedroom")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TodaysDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkOrder")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("JobDiscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sizeBathroom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sizeBedroom")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("JobDiscription");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            description = "interior walls, closet inside, ceiling",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 2,
                            description = "walls, closet inside",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 3,
                            description = "base boards",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 4,
                            description = "kitchen cabinet - inside and outside",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 5,
                            description = "all enamel surfaces including doors, door frames, kitchen, bathrooms",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 6,
                            description = "2 tone colors: navaho white, swiss coffee",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 7,
                            description = "2 tone colors: BM1520(Hushed Hue), swiss coffee",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 8,
                            description = "Balcony floor",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 9,
                            description = "Cover flooring and plastic",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        },
                        new
                        {
                            Id = 10,
                            description = "Ceiling",
                            price = 100,
                            sizeBathroom = 1,
                            sizeBedroom = 1
                        });
                });

            modelBuilder.Entity("Manager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("MyCompanyInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MyCompanyInfo");
                });

            modelBuilder.Entity("Properties", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GateCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LockBox")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "789 C St.",
                            City = "CityC",
                            GateCode = "GATE123",
                            LockBox = "LOCK123",
                            Name = "Property 1",
                            SpecialNote = "Property Note 1",
                            Zip = "33333"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 D St.",
                            City = "CityD",
                            GateCode = "GATE456",
                            LockBox = "LOCK456",
                            Name = "Property 2",
                            SpecialNote = "Property Note 2",
                            Zip = "44444"
                        });
                });

            modelBuilder.Entity("Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Supervisor");
                });

            modelBuilder.Entity("Companny2Property", b =>
                {
                    b.HasOne("Companny", "companny")
                        .WithMany("companny2Properties")
                        .HasForeignKey("CompannyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Properties", "properties")
                        .WithMany("companny2Properties")
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("companny");

                    b.Navigation("properties");
                });

            modelBuilder.Entity("Companny", b =>
                {
                    b.Navigation("companny2Properties");
                });

            modelBuilder.Entity("Properties", b =>
                {
                    b.Navigation("companny2Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
