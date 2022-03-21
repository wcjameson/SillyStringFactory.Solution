using Microsoft.EntityFrameworkCore;

namespace SillyStringFactory.Models
{
  public class SillyStringFactoryContext : DbContext
  {
    public DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<MachineEngineer> MachineEngineer { get; set; }
    public SillyStringFactoryContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}