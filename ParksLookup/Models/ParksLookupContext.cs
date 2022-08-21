using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ParksLookup.Models
{
  public class ParksLookupContext : IdentityDbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    public DbSet<State> States { get; set; }
    // public virtual DbSet<RefreshToken> ]RefreshTokens { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);
      builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Mount Rainier", Website = "https://www.nps.gov/mora/index.htm", StatePark = false, StateId = 1, Description = "An active volcano in Washington State." });

      builder.Entity<State>()
          .HasData(
              new State { StateId = 1, Name = "Washington", Abbr = "WA" });
    }
  }
}