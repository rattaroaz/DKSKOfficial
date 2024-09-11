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
    [Migration("20240911101132_addedIsLocked")]
    partial class addedIsLocked
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
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Companny");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 A St.",
                            City = "CityA",
                            Email = "ownerA@example.com",
                            Name = "Company A",
                            Phone = "123-456-7890",
                            SpecialNote = "Note A",
                            Zip = "11111"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 B St.",
                            City = "CityB",
                            Email = "ownerB@example.com",
                            Name = "Company B",
                            Phone = "987-654-3210",
                            SpecialNote = "Note B",
                            Zip = "22222"
                        });
                });

            modelBuilder.Entity("Contractor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("CellPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("ContractorID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LicenseNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PayrollPercent")
                        .HasColumnType("TEXT");

                    b.Property<string>("SocailSecurityNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contractor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "",
                            CellPhone = "",
                            City = "",
                            ContractorID = "",
                            Email = "",
                            LicenseNumber = "",
                            Name = "John Doe",
                            PayrollPercent = "",
                            SocailSecurityNumber = "",
                            SpecialNote = "",
                            Zip = ""
                        },
                        new
                        {
                            Id = 2,
                            Address = "",
                            CellPhone = "",
                            City = "",
                            ContractorID = "",
                            Email = "",
                            LicenseNumber = "",
                            Name = "David",
                            PayrollPercent = "",
                            SocailSecurityNumber = "",
                            SpecialNote = "",
                            Zip = ""
                        });
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

                    b.Property<string>("GarageRemoteCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("GateCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("InvoiceCreatedDate")
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
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("GarageRemoteCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("GateCode")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsLocked")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LockBox")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManagerEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManagerName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ManagerPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SpecialNote")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupervisorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Zip")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SupervisorId");

                    b.ToTable("Properties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "789 C St.",
                            City = "CityC",
                            GarageRemoteCode = "1234",
                            GateCode = "GATE123",
                            LockBox = "LOCK123",
                            ManagerEmail = "john@email.com",
                            ManagerName = "John",
                            ManagerPhone = "1234123",
                            Name = "Property 1",
                            SpecialNote = "Property Note 1",
                            SupervisorId = 1,
                            Zip = "33333"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 D St.",
                            City = "CityD",
                            GarageRemoteCode = "223a",
                            GateCode = "GATE456",
                            LockBox = "LOCK456",
                            ManagerEmail = "Doe@email.com",
                            ManagerName = "Doe",
                            ManagerPhone = "1234123",
                            Name = "Property 2",
                            SpecialNote = "Property Note 2",
                            SupervisorId = 1,
                            Zip = "44444"
                        });
                });

            modelBuilder.Entity("Supervisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CompanyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Supervisor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Email = "johndoe@gmail.com",
                            Name = "John Doe",
                            Phone = "12345543"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Email = "david@gmail.com",
                            Name = "David",
                            Phone = "12345543"
                        });
                });

            modelBuilder.Entity("Properties", b =>
                {
                    b.HasOne("Supervisor", "Supervisor")
                        .WithMany("Properties")
                        .HasForeignKey("SupervisorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supervisor");
                });

            modelBuilder.Entity("Supervisor", b =>
                {
                    b.HasOne("Companny", "Company")
                        .WithMany("Supervisors")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Companny", b =>
                {
                    b.Navigation("Supervisors");
                });

            modelBuilder.Entity("Supervisor", b =>
                {
                    b.Navigation("Properties");
                });
#pragma warning restore 612, 618
        }
    }
}
