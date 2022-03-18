using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SillyStringFactory.Models
{
  public class SillyStringFactoryContextFactory : IDesignTimeDbContextFactory<SillyStringFactoryContext>
  {

    SillyStringFactoryContext IDesignTimeDbContextFactory<SillyStringFactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SillyStringFactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SillyStringFactoryContext(builder.Options);
    }
  }
}