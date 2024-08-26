using Microsoft.EntityFrameworkCore;

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
                new JobDiscription { Id = 1, description = "interior walls, closet inside, ceiling" , price = 100},
                new JobDiscription { Id = 2, description = "walls, closet inside" , price = 100 },
                new JobDiscription { Id = 3, description = "base boards", price = 100 },
                new JobDiscription { Id = 4, description = "kitchen cabinet - inside and outside", price = 100 },
                new JobDiscription { Id = 5, description = "all enamel surfaces including doors, door frames, kitchen, bathrooms", price = 100 },
                new JobDiscription { Id = 6, description = "2 tone colors: navaho white, swiss coffee", price = 100 },
                new JobDiscription { Id = 7, description = "2 tone colors: BM1520(Hushed Hue), swiss coffee", price = 100 },
                new JobDiscription { Id = 8, description = "Balcony floor", price = 100 },
                new JobDiscription { Id = 9, description = "Cover flooring and plastic", price = 100 },
                new JobDiscription { Id = 10, description = "Ceiling", price = 100 }
            );

    }

    public DbSet<Companny> Companny { get; set; }
    public DbSet<Contractor> Contractor { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
    public DbSet<JobDiscription> JobDiscription { get; set; }
    public DbSet<Manager> Manager { get; set; }
    public DbSet<MyCompanyInfo> MyCompanyInfo { get; set; }
    public DbSet<Properties> Properties { get; set; }
    public DbSet<Supervisor> Supervisor { get; set; }

}
