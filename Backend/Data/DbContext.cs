using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using ICSharpCode.SharpZipLib.GZip;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
        modelBuilder.Entity<Supervisor>().HasData(
            new Supervisor { Id = 1, Name = "John Doe", CellPhone = "12345543", Email = "johndoe@gmail.com", SpecialNote = "" },
            new Supervisor { Id = 2, Name = "David", CellPhone = "12345543", Email = "david@gmail.com", SpecialNote = "" }
        );
        modelBuilder.Entity<Contractor>().HasData(
            new Contractor { Id = 1, Name = "John Doe", LicenseNumber = "", SocailSecurityNumber = "", ContractorID = "", PayrollPercent = "", CellPhone = "", Email = "", Address="", City = "", Zip = "", SpecialNote = "" },
            new Contractor { Id = 2, Name = "David", LicenseNumber = "", SocailSecurityNumber = "", ContractorID = "", PayrollPercent = "", CellPhone = "", Email = "", Address = "", City = "", Zip = "", SpecialNote = "" }
        );
        // Seed data for the Companny entity
        modelBuilder.Entity<Companny>().HasData(
            new Companny { Id = 1, Name = "Company A", Ownner = "Owner A", CellPhone = "123-456-7890", Email = "ownerA@example.com", Address = "123 A St.", City = "CityA", Zip = "11111", SpecialNote = "Note A" },
            new Companny { Id = 2, Name = "Company B", Ownner = "Owner B", CellPhone = "987-654-3210", Email = "ownerB@example.com", Address = "456 B St.", City = "CityB", Zip = "22222", SpecialNote = "Note B" }
        );

        // Seed data for the Properties entity
        modelBuilder.Entity<Properties>().HasData(
            new Properties { Id = 1, Name = "Property 1", Address = "789 C St.", City = "CityC", Zip = "33333", GateCode = "GATE123", LockBox = "LOCK123", SpecialNote = "Property Note 1", GarageRemoteCode = "1234" },
            new Properties { Id = 2, Name = "Property 2", Address = "123 D St.", City = "CityD", Zip = "44444", GateCode = "GATE456", LockBox = "LOCK456", SpecialNote = "Property Note 2", GarageRemoteCode ="223a" }
        );
        // Seed data for the Companny2Property (many-to-many relationship)
        modelBuilder.Entity<Companny2Property>().HasData(
            new Companny2Property { CompannyId = 1, PropertiesId = 1 }, // Company A to Property 1
            new Companny2Property { CompannyId = 1, PropertiesId = 2 }, // Company A to Property 2
            new Companny2Property { CompannyId = 2, PropertiesId = 1 }  // Company B to Property 1
        );

        modelBuilder.Entity<Companny2Property>().HasKey(e => new { e.CompannyId, e.PropertiesId });
        modelBuilder.Entity<Companny2Property>().HasOne(e => e.companny).WithMany(s => s.companny2Properties).HasForeignKey(e => e.CompannyId);
        modelBuilder.Entity<Companny2Property>().HasOne(e => e.properties).WithMany(s => s.companny2Properties).HasForeignKey(e => e.PropertiesId);

        modelBuilder.Entity<Companny2Manager>().HasKey(e => new { e.CompannyId, e.ManagerId });
        modelBuilder.Entity<Companny2Manager>().HasOne(e => e.companny).WithMany(s => s.companny2Manager).HasForeignKey(e => e.CompannyId);
        modelBuilder.Entity<Companny2Manager>().HasOne(e => e.manager).WithMany(s => s.companny2Manager).HasForeignKey(e => e.ManagerId);

        modelBuilder.Entity<Companny2Supervisor>().HasKey(e => new { e.CompannyId, e.SupervisorId });
        modelBuilder.Entity<Companny2Supervisor>().HasOne(e => e.companny).WithMany(s => s.companny2Supervisor).HasForeignKey(e => e.CompannyId);
        modelBuilder.Entity<Companny2Supervisor>().HasOne(e => e.supervisor).WithMany(s => s.companny2Supervisor).HasForeignKey(e => e.SupervisorId);

        modelBuilder.Entity<Manager2Property>().HasKey(e => new { e.ManagerId, e.PropertiesId });
        modelBuilder.Entity<Manager2Property>().HasOne(e => e.manager).WithMany(s => s.manager2Property).HasForeignKey(e => e.ManagerId);
        modelBuilder.Entity<Manager2Property>().HasOne(e => e.properties).WithMany(s => s.manager2Properties).HasForeignKey(e => e.PropertiesId);

        modelBuilder.Entity<Manager2Supervisor>().HasKey(e => new { e.ManagerId, e.SupervisorId });
        modelBuilder.Entity<Manager2Supervisor>().HasOne(e => e.manager).WithMany(s => s.manager2Supervisor).HasForeignKey(e => e.ManagerId);
        modelBuilder.Entity<Manager2Supervisor>().HasOne(e => e.supervisor).WithMany(s => s.manager2Supervisor).HasForeignKey(e => e.SupervisorId);

        modelBuilder.Entity<Supervisor2Property>().HasKey(e => new { e.SupervisorId, e.PropertiesId });
        modelBuilder.Entity<Supervisor2Property>().HasOne(e => e.supervisor).WithMany(s => s.supervisor2Properties).HasForeignKey(e => e.SupervisorId);
        modelBuilder.Entity<Supervisor2Property>().HasOne(e => e.properties).WithMany(s => s.supervisor2Properties).HasForeignKey(e => e.PropertiesId);

    }

    public DbSet<Companny> Companny { get; set; }
    public DbSet<Contractor> Contractor { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
    public DbSet<JobDiscription> JobDiscription { get; set; }
    public DbSet<Manager> Manager { get; set; }
    public DbSet<MyCompanyInfo> MyCompanyInfo { get; set; }
    public DbSet<Properties> Properties { get; set; }
    public DbSet<Supervisor> Supervisor { get; set; }
    public DbSet<Companny2Property> Companny2Property { get; set; }
}
