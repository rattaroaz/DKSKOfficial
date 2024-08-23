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
    }

    public DbSet<Companny> Companny { get; set; }
    public DbSet<Contractor> Contractor { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
    public DbSet<JobDiscription> JobDiscriptions { get; set; }
    public DbSet<Manager> Manager { get; set; }
    public DbSet<MyCompanyInfo> MyCompanyInfo { get; set; }
    public DbSet<Properties> Properties { get; set; }
    public DbSet<Supervisor> Supervisor { get; set; }

}
