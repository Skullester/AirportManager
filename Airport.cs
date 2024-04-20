using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Airport
{
    [Key]
    public int id { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public List<Airplane> airplanes { get; set; }
    public int Count { get; set; }
    public Airport(string name, string address, string INN)
    {
        this.name = name;
        this.address = address;
        this.INN = INN;
    }
    public string INN { get; set; }
    public override string ToString()
    {
        return name;
    }
}
