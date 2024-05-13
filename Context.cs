using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;

namespace Airport;

public class Context : DbContext
{
    public Context()
    {
        Database.EnsureCreated();
    }

    public DbSet<Airport> Airports { get; set; }
    public DbSet<Airplane> Airplanes { get; set; }
    public DbSet<Destination> Destinations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=airplane.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airport>(AirportConfigure);
        modelBuilder.Entity<Airplane>(AirplaneConfigure);
    }

    private void AirplaneConfigure(EntityTypeBuilder<Airplane> builder)
    {
        var airplanes = new List<Airplane>
        {
            new Airplane("МС-21", 1, 910, 6400)
                { id = 1 },
            new Airplane("Ту-214", 2, 850, 7200)
                { id = 2 },
            new Airplane("Boeing 737 MAX", 3, 835, 6570)
                { id = 3 },
            new Airplane("Boeing 777X", 2, 900, 13500)
                { id = 4 },
        };
        builder.HasData(airplanes);
    }

    private void AirportConfigure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasAlternateKey(port => port.INN);
        var airports = new Airport[]
        {
            new Airport("Шереметьево", "г.Москва", "1234567890", 0) { id = 1 },
            new Airport("Внуково", "г.Москва", "1234567892", 0) { id = 2 },
            new Airport("Домодедово", "г.Москва", "1224567891", 0) { id = 3 },
            new Airport("АэропортТокио", "г.Токио", "1214567891", 7484) { id = 4 },
            new Airport("АэропортФранция", "г.Париж", "1334567891", 2486) { id = 5 },
            new Airport("АэропортАнкара", "г.Анкара", "1434567891", 1796) { id = 6 },
            new Airport("АэропортСША", "г.Вашингтон", "1534567891", 7822) { id = 7 }
        };
        builder.HasData(airports);
    }
}