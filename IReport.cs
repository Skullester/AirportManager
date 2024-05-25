using Microsoft.EntityFrameworkCore;

namespace Airport;

public interface IReport
{
    void Report(ReportForm reportForm);
}
class NearestFlightsReport : IReport
{
    private Context context;
    public NearestFlightsReport(Context context)
    {
        this.context = context;
    }
    public void Report(ReportForm reportForm)
    {
        var query = context.Destinations
            .Include(x => x.airplane)
    //        .Include(x => x.start_airport)
            //.Include(x => x.end_airport)
            .OrderBy(x => x.FlightDate)
            .Where(x => !x.IsFlying)
            .Select(x => new
            {
                Самолет = x.airplane,
        //        Начальный_Аэропорт = x.start_airport,
             //   Конечный_Аэропорт = x.end_airport,
                Часов_Полета = x.flight_hours,
                Дата_Полета = x.FlightDate
            }
            )
            .Take(5);
        var dataSource = query.ToList();
        reportForm.dataGridView1.DataSource = dataSource;
        reportForm.label1.Text = "Ближайшие рейсы";
    }
    public override string ToString()
    {
        return "Ближайшие рейсы";
    }
}
//class DestinationReport : IReport
//{
//    private Context context;
//    private MainForm mainForm;
//    public DestinationReport(Context context, MainForm mainForm)
//    {
//        this.context = context;
//        this.mainForm = mainForm;
//    }

//    public void Report(ReportForm reportForm)
//    {
//        var airport = mainForm.comboBoxAirports.SelectedItem as Airport;
//        var query = context.Destinations
//           .Include(x => x.airplane)
//           .Include(x => x.start_airport)
//           .Include(x => x.end_airport)
//           .OrderBy(x => x.FlightDate)
//           .Where(x => !x.IsFlying && x.end_airportid == airport.id)
//           .Select(x => new
//           {
//               Самолет = x.airplane,
//               Начальный_Аэропорт = x.start_airport,
//               Конечный_Аэропорт = x.end_airport,
//               Часов_Полета = x.flight_hours,
//               Дата_Полета = x.FlightDate
//           });
//        var result = query.ToList();
//        reportForm.dataGridView1.DataSource = result;
//    }
//    public override string ToString()
//    {
//        return "Список маршрутов по конечному пункту";
//    }
//}
class TheMostFrequentlyDestinations : IReport
{
    private Context context;
    public TheMostFrequentlyDestinations(Context context)
    {
        this.context = context;
    }

    public void Report(ReportForm reportForm)
    {
        var query = context.Airports.Where(x => x.address != "г.Москва")
           .OrderByDescending(x => x.Count)
           .Select(x => new
           {
               Назначение = x.name,
               Количество = x.Count,
               Адрес = x.address
           });
        var result = query.ToList();
        reportForm.dataGridView1.DataSource = result;
    }
    public override string ToString()
    {
        return "Самые частые пункты назначения";
    }
}
