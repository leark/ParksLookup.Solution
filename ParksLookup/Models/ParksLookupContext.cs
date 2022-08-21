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
              new Park { ParkId = 1, Name = "Mount Rainier", Website = "https://www.nps.gov/mora/index.htm", StatePark = false, StateId = 53, Description = "An active volcano in Washington State." });

      builder.Entity<State>()
          .HasData(
              new State { StateId = 1, Name = "Alabama", Abbr = "AL" },
              new State { StateId = 2, Name = "Alaska", Abbr = "AK" },
              new State { StateId = 4, Name = "Arizona", Abbr = "AZ" },
              new State { StateId = 5, Name = "Arkansas", Abbr = "AR" },
              new State { StateId = 6, Name = "California", Abbr = "CA" },
              new State { StateId = 8, Name = "Colorado", Abbr = "CO" },
              new State { StateId = 9, Name = "Connecticut", Abbr = "CT" },
              new State { StateId = 10, Name = "Delaware", Abbr = "DE" },
              new State { StateId = 11, Name = "District of Columbia", Abbr = "DC" },
              new State { StateId = 12, Name = "Florida", Abbr = "FL" },
              new State { StateId = 13, Name = "Georgia", Abbr = "13" },
              new State { StateId = 15, Name = "Hawaii", Abbr = "15" },
              new State { StateId = 16, Name = "Idaho", Abbr = "ID" },
              new State { StateId = 17, Name = "Illinois", Abbr = "IL" },
              new State { StateId = 18, Name = "Indiana", Abbr = "IN" },
              new State { StateId = 19, Name = "Iowa", Abbr = "IA" },
              new State { StateId = 20, Name = "Kansas", Abbr = "KS" },
              new State { StateId = 21, Name = "Kentucky", Abbr = "21" },
              new State { StateId = 22, Name = "Louisiana", Abbr = "LA" },
              new State { StateId = 23, Name = "Maine", Abbr = "ME" },
              new State { StateId = 24, Name = "Maryland", Abbr = "MD" },
              new State { StateId = 25, Name = "Massachusetts", Abbr = "MA" },
              new State { StateId = 26, Name = "Michigan", Abbr = "MI" },
              new State { StateId = 27, Name = "Minnesota", Abbr = "MN" },
              new State { StateId = 28, Name = "Mississippi", Abbr = "MS" },
              new State { StateId = 29, Name = "Missouri", Abbr = "MO" },
              new State { StateId = 30, Name = "Montana", Abbr = "MT" },
              new State { StateId = 31, Name = "Nebraska", Abbr = "NE" },
              new State { StateId = 32, Name = "Nevada", Abbr = "NV" },
              new State { StateId = 33, Name = "New Hampshire", Abbr = "NH" },
              new State { StateId = 34, Name = "New Jersey", Abbr = "NJ" },
              new State { StateId = 35, Name = "New Mexico", Abbr = "NM" },
              new State { StateId = 36, Name = "New York", Abbr = "NY" },
              new State { StateId = 37, Name = "North Carolina", Abbr = "NC" },
              new State { StateId = 38, Name = "North Dakota	", Abbr = "ND" },
              new State { StateId = 39, Name = "Ohio", Abbr = "OH" },
              new State { StateId = 40, Name = "Oklahoma", Abbr = "OK" },
              new State { StateId = 41, Name = "Oregon", Abbr = "OR" },
              new State { StateId = 42, Name = "Pennsylvania", Abbr = "PA" },
              new State { StateId = 44, Name = "Rhode Island	", Abbr = "RI" },
              new State { StateId = 45, Name = "South Carolina", Abbr = "SC" },
              new State { StateId = 46, Name = "South Dakota	", Abbr = "SD" },
              new State { StateId = 47, Name = "Tennessee", Abbr = "TN" },
              new State { StateId = 48, Name = "Texas", Abbr = "TX" },
              new State { StateId = 49, Name = "Utah", Abbr = "UT" },
              new State { StateId = 50, Name = "Vermont", Abbr = "VT" },
              new State { StateId = 51, Name = "Virgin Islands	", Abbr = "VA" },
              new State { StateId = 53, Name = "Washington", Abbr = "WA" },
              new State { StateId = 54, Name = "West Virginia	", Abbr = "WV" },
              new State { StateId = 55, Name = "Wisconsin", Abbr = "WI" },
              new State { StateId = 56, Name = "Wyoming", Abbr = "WY" }
              );
    }
  }
}