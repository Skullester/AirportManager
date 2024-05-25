using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Position
{
    [Key] public int id { get; set; }
    public List<Employee> employees { get; set; }
    public string name { get; set; }

    public Position(string name)
    {
        this.name = name;
    }

    public override string ToString() => name;
}