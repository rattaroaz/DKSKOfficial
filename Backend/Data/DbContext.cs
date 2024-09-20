﻿using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using ICSharpCode.SharpZipLib.GZip;
using Microsoft.EntityFrameworkCore;
using System.Net;
using BCrypt.Net;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure relationships, keys, etc. if needed
        modelBuilder.Entity<JobDiscription>().HasData(
                new JobDiscription { Id = 1, description = "interior walls, closet inside, ceiling" , sizeBathroom = 1, sizeBedroom =1, price = 100},
                new JobDiscription { Id = 2, description = "walls, closet inside", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 3, description = "base boards", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 4, description = "kitchen cabinet - inside and outside", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 5, description = "all enamel surfaces including doors, door frames, kitchen, bathrooms", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 6, description = "2 tone colors: navaho white, swiss coffee", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 7, description = "2 tone colors: BM1520(Hushed Hue), swiss coffee", sizeBathroom = 1, sizeBedroom = 1, price= 100 },
                new JobDiscription { Id = 8, description = "Balcony floor", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 9, description = "Cover flooring and plastic", sizeBathroom = 1, sizeBedroom = 1, price = 100 },
                new JobDiscription { Id = 10, description = "Ceiling", sizeBathroom = 1, sizeBedroom = 1, price = 100 }
            );
        modelBuilder.Entity<MyCompanyInfo>().HasData(
            new MyCompanyInfo { Id = 1, Name = "DKSK Company", Phone = "123-456-7890", Email = "ownerA@example.com", Address = "123 A St.",LicenseNumber = "123123", Zip = "1234" }
        );
        modelBuilder.Entity<Contractor>().HasData(
            new Contractor { Id = 1, Name = "John Doe", LicenseNumber = "", SocailSecurityNumber = "", ContractorID = "", PayrollPercent = "", CellPhone = "", Email = "", Address="", City = "", Zip = "", SpecialNote = "", IsActive = true },
            new Contractor { Id = 2, Name = "David", LicenseNumber = "", SocailSecurityNumber = "", ContractorID = "", PayrollPercent = "", CellPhone = "", Email = "", Address = "", City = "", Zip = "", SpecialNote = "", IsActive = true }
        );
        // Seed data for the Companny entity
        modelBuilder.Entity<Companny>().HasData(
            new Companny { Id = 1, Name = "Company A",Phone = "123-456-7890", Email = "ownerA@example.com", Address = "123 A St.", City = "CityA", Zip = "11111", SpecialNote = "Note A" },
            new Companny { Id = 2, Name = "Company B", Phone = "987-654-3210", Email = "ownerB@example.com", Address = "456 B St.", City = "CityB", Zip = "22222", SpecialNote = "Note B" }
        );
        // Define relationships
        // One-to-Many relationship between Companny and Supervisor
        modelBuilder.Entity<Supervisor>()
            .HasOne(s => s.Company)
            .WithMany(c => c.Supervisors)
            .HasForeignKey(s => s.CompanyId)
            .OnDelete(DeleteBehavior.Cascade);


        modelBuilder.Entity<Properties>()
            .HasOne(p => p.Supervisor)
            .WithMany(s => s.Properties)
            .HasForeignKey(p => p.SupervisorId)
            .OnDelete(DeleteBehavior.Cascade);
        // Seed data for Supervisor and other entities
        modelBuilder.Entity<Supervisor>().HasData(
            new Supervisor { Id = 1, Name = "John Doe", Phone = "12345543", Email = "johndoe@gmail.com", CompanyId = 1 },
            new Supervisor { Id = 2, Name = "David", Phone = "12345543", Email = "david@gmail.com", CompanyId = 1 }
        );

        modelBuilder.Entity<Properties>().HasData(
            new Properties { Id = 1, Name = "Property 1", Address = "789 C St.", City = "CityC", Zip = "33333", GateCode = "GATE123", LockBox = "LOCK123", SpecialNote = "Property Note 1", GarageRemoteCode = "1234", ManagerName = "John", ManagerEmail = "john@email.com", ManagerPhone = "1234123", SupervisorId = 1, IsActive = true },
            new Properties { Id = 2, Name = "Property 2", Address = "123 D St.", City = "CityD", Zip = "44444", GateCode = "GATE456", LockBox = "LOCK456", SpecialNote = "Property Note 2", GarageRemoteCode = "223a", ManagerName = "Doe", ManagerEmail = "Doe@email.com", ManagerPhone = "1234123", SupervisorId = 1, IsActive = true }
        );
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Username = "admin",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password"),
                Role = "admin"
            },
            new User
            {
                Id = 2,
                Username = "guest",
                PasswordHash = BCrypt.Net.BCrypt.HashPassword("password"),
                Role = "guest"
            }
        );
    }
    // Seed default users
    
    public DbSet<Companny> Companny { get; set; }
    public DbSet<Contractor> Contractor { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
    public DbSet<JobDiscription> JobDiscription { get; set; }
    public DbSet<MyCompanyInfo> MyCompanyInfo { get; set; }
    public DbSet<Properties> Properties { get; set; }
    public DbSet<Supervisor> Supervisor { get; set; }
    public DbSet<User> Users { get; set; }


}
