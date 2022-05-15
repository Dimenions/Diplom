using Microsoft.EntityFrameworkCore;
using SSU.Coins.Entities;
public class CoinsContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RoleWebSite> RoleWebSites { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Coin> Coins { get; set; }

    public CoinsContext(DbContextOptions<CoinsContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    /*public CoinsContext()
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("ConnectionString");
        }
 }*/

}
