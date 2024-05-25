using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Service
{
    [Key] public int id { get; set; }
    [Required] public string name { get; set; }

    public Service(string name)
    {
        this.name = name;
    }
}