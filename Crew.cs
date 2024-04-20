using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Crew
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
}
