using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data;

public class DataContext : DbContext
{
    // public DataContext(DbContextOptions<DataContext> options) : base(options)
    // {
    //     
    // }
    //
    // public DbSet<Character> Characters {get; set; }
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings
        var connectionString = Configuration.GetConnectionString("MySql");
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    public DbSet<Character> Characters {get; set; }
}