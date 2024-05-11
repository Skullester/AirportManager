namespace Airport;

public partial class MainForm : Form
{
    private IReport report = null!;
    private Context Context;
    private Thread thread;
    public MainForm()
    {
        InitializeComponent();
        Initialize();
        InitializeTables();
    }

    public void InitializeTables()
    {
        var query = from dest in Context.Destinations
                    join airplane in Context.Airplanes on dest.airplaneid equals airplane.id
                    select new
                    {
                        Самолет = dest.airplane,
                        Часы_Полета = dest.flight_hours,
                        Начальный_Аэропорт = dest.start_airport,
                        Конечный_Аэропорт = dest.end_airport,
                        Дата_Полета = dest.FlightDate,
                        В_Полете = dest.IsFlying
                    };
        var result = query.ToList();
        if (Thread.CurrentThread.Name == "Second")
            dataGridViewDestinations.BeginInvoke(() => dataGridViewDestinations.DataSource = result);
        else dataGridViewDestinations.DataSource = result;
    }

    private void Initialize()
    {
        Context = new();
        thread = new(CheckFlight) { Name = "Second" };
        thread.Start();
        comboBoxReport.Items.AddRange([new NearestFlightsReport(Context), /*new DestinationReport(Context, this)*/ new TheMostFrequentlyDestinations(Context)]);
        comboBoxReport.SelectedValueChanged += OnReportChanged;
        foreach (var item in Controls)
        {
            if (item is ComboBox cb)
                cb.SelectedIndex = 0;
        }
    }

    private void OnReportChanged(object? obj, EventArgs e)
    {
        report = (comboBoxReport.SelectedItem as IReport)!;
    }

    private void CheckFlight()
    {
        while (true)
        {
            Thread.Sleep(20000);
            var destinations = Context.Destinations.ToList();
            foreach (var dest in destinations)
            {
                if (!dest.IsFlying && dest.FlightDate.Minute == DateTime.Now.Minute && dest.FlightDate.Hour == DateTime.Now.Hour && dest.FlightDate.Day == DateTime.Now.Day)
                {
                    var airportEnd = dest.end_airport;

                    dest.IsFlying = true;
                    Context.Destinations.Update(dest);
                    dest.airplane.isFree = false;
                    Context.Airplanes.Update(dest.airplane);
                    Context.Airports.Update(airportEnd);
                    Context.SaveChanges();
                    InitializeTables();
                }
            }
        }
    }
    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        thread.Interrupt();
    }

    private void AddFlight(object sender, EventArgs e)
    {
        new AddingFlightForm(this).ShowDialog();
    }

    private void MakeReport(object sender, EventArgs e)
    {
        if (Context.Destinations.Count() == 0)
        {
            MessageBox.Show("Отчетность пуста!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        var reportForm = new ReportForm();
        report.Report(reportForm);
        reportForm.ShowDialog();
    }
}
