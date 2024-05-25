using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Airplane
{
    [Key] public int id { get; set; }
    public Airport airport { get; set; }
    public int? airportid { get; set; }

    public string name { get; set; }

    //public List<Destination> destination { get; set; }
    public double Speed { get; set; }
    public int MaxDistance { get; set; }

    public Airplane(string name, int? airportid, double speed, int maxDistance)
    {
        this.name = name;
        this.airportid = airportid;
        Speed = speed;
        MaxDistance = maxDistance;
    }

    public override string ToString()
    {
        return name;
    }
}