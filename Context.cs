using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Emit;

namespace Airport;
public class Context : DbContext
{
    public Context()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    public DbSet<Airport> Airports { get; set; }
    public DbSet<Airplane> Airplanes { get; set; }
    public DbSet<Employee> Personal { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Destination> Destinations { get; set; }
    public DbSet<Service> Services { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=airplane.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airport>(AirportConfigure);
        modelBuilder.Entity<Airplane>(AirplaneConfigure);
        modelBuilder.Entity<Destination>(DestinationConfigure);
        modelBuilder.Entity<Position>(PositionConfigure);
        modelBuilder.Entity<Employee>(EmployeeConfigure);
        modelBuilder.Entity<Service>(ServiceConfigure);
        modelBuilder.Entity<Employee>().ToTable(t => t.HasCheckConstraint("ValidINN", "LENGTH(INN) == 12"));
    }
    private void ServiceConfigure(EntityTypeBuilder<Service> builder)
    {
        var airplanes = new List<Service>
        {
            new Service("Медицинская служба")
            {id = 1 },
            new Service("Аэронавигационная")
            {id = 3 },
            new Service("Аэродромная")
            {id = 4 },
            new Service("Cправочная")
            {id = 5 },
            new Service("Осуществление воздушных перевозок")
            {id = 6 },
        };
        builder.HasData(airplanes);
    }

    private void EmployeeConfigure(EntityTypeBuilder<Employee> builder)
    {
        var airplanes = new List<Employee>
        {
            new Employee(6,1,1,"Иванов Алексей Викторович","585032751399")
            {id = 1 },
            new Employee(5,2,5,"Шубин Игорь Васильевич","105758390771")
            {id = 2},
            new Employee(6,1,2,"Измайлова Екатерина Юрьевна","692955486942" )
            {id = 3 },
            new Employee (3,3,3,"Тукаев Артем Игоревич","644867207164")
            {id = 4 },
            new Employee (1,1,6,"Белых Виктор Евгеньевич","559170343700")
            {id = 5 },
            new Employee (6,2,2,"Васницов Александр Александрович","488500292639")
            {id = 6 },
            new Employee (6,1,2,"Кузнецов Виктор Сергеевич","501126060983")
            {id = 7 },
            new Employee (3,2,3,"Калабаев Павел Николаевич","728421136801")
            {id = 8 },
            new Employee (4,1,4,"Князев Алексей Игоревич","585898602516")
            {id = 9 },
        };
        builder.HasData(airplanes);
    }

    private void PositionConfigure(EntityTypeBuilder<Position> builder)
    {
        var airplanes = new List<Position>
        {
            new Position("Пилот")
            {id = 1 },
            new Position("Бортпроводник")
            {id = 2},
            new Position("Авиадиспетчер")
            {id = 3 },
            new Position ("Борт-инженер")
            {id = 4 },
            new Position ("Оператор")
            {id = 5 },
            new Position ("Медик")
            {id = 6 },
        };
        builder.HasData(airplanes);
    }
    private void AirplaneConfigure(EntityTypeBuilder<Airplane> builder)
    {
        var airplanes = new List<Airplane>
        {
            new Airplane("Boeing 777",1, true)
            {id = 1 },
            new Airplane("МС-21",2, true)
            {id = 2},
            new Airplane("Sukhoi Superjet 100",3,false)
            {id = 3 },
            new Airplane("Ан-124",2,true)
            {id = 4 },

        };
        builder.HasData(airplanes);
    }
    private void DestinationConfigure(EntityTypeBuilder<Destination> builder)
    {
        var destinations = new List<Destination>
        {
            new Destination(3,1,4,9,DateTime.Now + TimeSpan.FromSeconds(60)) {id = 1},
            new Destination(2,1,4,9,DateTime.Now + TimeSpan.FromSeconds(30)) {id = 2},
            new Destination(1,1,4,9,DateTime.Now + TimeSpan.FromHours(4)) {id = 3},
            new Destination(2,1,4,9,DateTime.Now + TimeSpan.FromHours(6)) {id = 4},
            new Destination(4,1,4,9,DateTime.Now + TimeSpan.FromHours(8)) {id = 5},
        };
        builder.HasData(destinations);
    }

    private void AirportConfigure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasAlternateKey(port => port.INN);
        var airports = new Airport[]
        {
            new Airport("Шереметьево", "г.Москва", "1234567890") { id = 1 },
            new Airport("Внуково", "г.Москва", "1234567892") { id = 2 },
            new Airport("Домодедово", "г.Москва", "1224567891") { id = 3 },
            new Airport("АэропортТокио", "г.Токио", "1214567891") { id = 4 },
            new Airport("АэропортКанберра", "г.Канберра", "1334567891") { id = 5 },
            new Airport("АэропортАнкара", "г.Анкара", "1434567891") { id = 6 },
            new Airport("АэропортФранция", "г.Вашингтон", "1534567891") { id = 7 }
        };
        builder.HasData(airports);
    }
}

