using BaldursGateAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BaldursGateAPI.Helpers;

public class DataContext : DbContext
{
    private readonly IConfiguration _configuration;

    public DataContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(_configuration.GetConnectionString("WebApiDatabase"));
    }
    
    public DbSet<AbilityScore> AbilityScores { get; set; }

    public virtual DbSet<Alignment> Alignments { get; set; }
    
    public virtual DbSet<Association> Association { get; set; }

    public virtual DbSet<Character> Characters { get; set; }
    
    public virtual DbSet<Class> Classes { get; set; }
    
    public virtual DbSet<Location> Locations { get; set; }
    
    public virtual DbSet<Race> Races { get; set; }
    


}
