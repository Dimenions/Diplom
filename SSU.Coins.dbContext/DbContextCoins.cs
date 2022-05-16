using Microsoft.EntityFrameworkCore;
using SSU.Coins.Entities;
public class CoinsContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RoleWebSite> RoleWebSites { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Coin> Coins { get; set; }

    /*public CoinsContext(DbContextOptions<CoinsContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }*/

    /*public CoinsContext()
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    */
    //Add-Migration Initial
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            //optionsBuilder.UseSqlServer("ConnectionString");
            optionsBuilder.UseSqlServer(@"Server = (LocalDb)\MSSQLLocalDB; initial catalog = SSU.Coins.dbContext.SSU.Coin; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
            //Первый варик нужно вернуть, но хз как это затестить 
        }
    }

}
