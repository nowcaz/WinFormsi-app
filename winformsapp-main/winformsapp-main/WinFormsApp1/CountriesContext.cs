using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1;

public class CountriesContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Continent> Continents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Continent>().HasData(
            new Continent { ContinentId = 1, Name = "Asia" },
            new Continent { ContinentId = 2, Name = "Africa" },
            new Continent { ContinentId = 3, Name = "North America" },
            new Continent { ContinentId = 4, Name = "South America" },
            new Continent { ContinentId = 5, Name = "Europe" },
            new Continent { ContinentId = 6, Name = "Oceania" });
                            
        modelBuilder.Entity<Country>().HasData(
            new Country { CountryId = 1, ContinentId = 2, Name = "Liberia" },
            new Country { CountryId = 2, ContinentId = 1, Name = "Iran" },
            new Country { CountryId = 3, ContinentId = 1, Name = "Brunei" },
            new Country { CountryId = 4, ContinentId = 2, Name = "Mauritius" },
            new Country { CountryId = 5, ContinentId = 1, Name = "Azerbaijan" },
            new Country { CountryId = 6, ContinentId = 6, Name = "Nauru" },
            new Country { CountryId = 7, ContinentId = 1, Name = "North Korea" },
            new Country { CountryId = 8, ContinentId = 1, Name = "Thailand" },
            new Country { CountryId = 9, ContinentId = 2, Name = "Zimbabwe" },
            new Country { CountryId = 10,ContinentId = 5, Name = "France" },
            new Country { CountryId = 11, ContinentId = 5, Name = "Liechtenstein" },
            new Country { CountryId = 12, ContinentId = 3, Name = "Cuba" },
            new Country { CountryId = 13, ContinentId = 4, Name = "Peru" },
            new Country { CountryId = 14, ContinentId = 6, Name = "New Zealand" },
            new Country { CountryId = 15, ContinentId = 2, Name = "Algeria" },
            new Country { CountryId = 16, ContinentId = 2, Name = "Congo" },
            new Country { CountryId = 17, ContinentId = 5, Name = "Spain" },
            new Country { CountryId = 18, ContinentId = 1, Name = "Oman" },
            new Country { CountryId = 19, ContinentId = 2, Name = "Ethiopia" },
            new Country { CountryId = 20, ContinentId = 5, Name = "Iceland" },
            new Country { CountryId = 21, ContinentId = 4, Name = "Venezuela" },
            new Country { CountryId = 22, ContinentId = 2, Name = "Rwanda" },
            new Country { CountryId = 23, ContinentId = 5, Name = "Greece" },
            new Country { CountryId = 24, ContinentId = 1, Name = "Philippines" },
            new Country { CountryId = 25, ContinentId = 2, Name = "Guinea-Bissau" },
            new Country { CountryId = 26, ContinentId = 1, Name = "Saudi Arabia" },
            new Country { CountryId = 27, ContinentId = 3, Name = "Jamaica" },
            new Country { CountryId = 28, ContinentId = 2, Name = "Sudan" },
            new Country { CountryId = 29, ContinentId = 2, Name = "Botswana" },
            new Country { CountryId = 30, ContinentId = 5, Name = "Estonia" },
            new Country { CountryId = 31, ContinentId = 1, Name = "Singapore" },
            new Country { CountryId = 32, ContinentId = 3, Name = "Haiti" },
            new Country { CountryId = 33, ContinentId = 5, Name = "Belarus" });
    }
}