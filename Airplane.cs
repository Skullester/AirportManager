using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Airplane
{
    [Key]
    public int id { get; set; }
    public Airport airport { get; set; }
    public int airportid { get; set; }
    public string name { get; set; }
    public List<Destination> destination { get; set; }
    public bool isFree { get; set; }
    public Airplane(string name, int airportid, bool isFree)
    {
        this.name = name;
        this.airportid = airportid;
        this.isFree = isFree;
    }
    public override string ToString()
    {
        return name;
    }
}
