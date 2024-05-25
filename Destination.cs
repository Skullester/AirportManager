using System.ComponentModel.DataAnnotations;

namespace Airport;

public class Destination
{
    [Key] public int id { get; set; }
    /*
    public Airport start_airport { get; set; }

    public int start_airportid { get; set; }
    */

    /*public Airport end_airport { get; set; }
    public int end_airportid { get; set; }*/
    public byte flight_hours { get; set; }
    public Airplane airplane { get; set; }
    public int airplaneid { get; set; }
    public DateTime FlightDate { get; set; }
    public bool IsFlying { get; set; }

    public Destination(int airplaneid, /* int start_airportid,*/ /*int end_airportid,*/ byte flight_hours,
        DateTime FlightDate)
    {
        this.airplaneid = airplaneid;
        // this.start_airportid = start_airportid;
        // this.end_airportid = end_airportid;
        this.flight_hours = flight_hours;
        this.FlightDate = FlightDate;
    }
}