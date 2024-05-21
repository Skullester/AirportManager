using Microsoft.EntityFrameworkCore;

namespace Airport;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        using (ApplicationContextq db = new ApplicationContextq())
        {
            // пересоздадим базу данных
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            // добавляем начальные данные
            Company microsoft = new Company { Name = "Microsoft" };
            Company google = new Company { Name = "Google" };
            db.Companies.AddRange(microsoft, google);


            User tom = new User { Name = "Tom", Company = microsoft };
            User bob = new User { Name = "Bob", Company = google };
            User alice = new User { Name = "Alice", Company = microsoft };
            User kate = new User { Name = "Kate", Company = google };
            db.Users.AddRange(tom, bob, alice, kate);

            db.SaveChanges();
        }

        ApplicationContextq a = new();
        Company? company = a.Companies.FirstOrDefault();
        Company? company2 = a.Find(2);
        a.Users.Where(x => true).ToList();
    }
}

public class ApplicationContextq : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Company> Companies { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=helloapp21.db");
    }
}

public class Company
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public List<User> Users { get; set; } = new();
}

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int? CompanyId { get; set; }
    public Company? Company { get; set; }
}