using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Employee
{
    [Key]
    public int id { get; set; }
    public string INN { get; set; }
    public string fullname { get; set; }
    public Airport Airport { get; set; }
    public int AirportId { get; set; }
    public Position position { get; set; }
    public Service Service { get; set; }
    public int ServiceId { get; set; }
    public int positionid { get; set; }
    public Employee(int ServiceId, int AirportId, int positionid, string fullname, string INN)
    {
        this.ServiceId = ServiceId;
        this.AirportId = AirportId;
        this.positionid = positionid;
        this.fullname = fullname;
        this.INN = INN;
    }

}
