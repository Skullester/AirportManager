namespace Airport;

public partial class AddingFlightForm : Form
{
    private Context context;
    private readonly MainForm mainForm;

    public AddingFlightForm(MainForm mainForm)
    {
        InitializeComponent();
        context = new();
        InitializeTables();
        InitializeControls();
        this.mainForm = mainForm;
    }

    private void InitializeControls()
    {
        var airplanes = context.Airplanes.ToArray(); /*.Where(x => x.isFree).ToArray();*/
        var airportsIn = context.Airports.Where(x => x.address != "г.Москва").ToArray();
        var airportsOut = context.Airports.Where(x => x.address == "г.Москва").ToArray();
        comboBox1.Items.AddRange(airplanes);
        comboBoxOut.Items.AddRange(airportsOut);
        comboBoxIn.Items.AddRange(airportsIn);
        DateTime maxDate;
        if (!context.Destinations.Any())
        {
            maxDate = DateTime.Now.AddHours(-1).AddMinutes(1);
        }
        else maxDate = context.Destinations.Select(x => x.FlightDate).Max();

        var dates = new object[]
        {
            maxDate.AddHours(1),
            maxDate.AddHours(2),
            maxDate.AddHours(3),
            maxDate.AddHours(4),
            maxDate.AddHours(5),
        };
        comboBoxDate.Items.AddRange(dates);
        foreach (var control in Controls)
            if (control is ComboBox cb)
                cb.SelectedIndex = 0;
    }

    private void InitializeTables()
    {
        var query = context.Airplanes.Join(context.Airports, pl => pl.airportid, port => port.id, (pl, port) =>
            new
            {
                Самолет = pl.name,
                Аэропорт = port.name,
                // Свободен = pl.isFree,
                Скорость = pl.Speed + "км/ч",
                Максимальное_Расстояние = pl.MaxDistance + "км"
            });

        var result = query.ToList();
        dataGridViewAirplanes.DataSource = result;

        var query2 = context.Airports.Select(port => new
        {
            Название = port.name,
            ИНН = port.INN,
            Адрес = port.address,
            Расстояние = port.Distance + "км"
        });
        var result2 = query2.ToList();
        dataGridViewAirports.DataSource = result2;
    }

    private void Add(object sender, EventArgs e)
    {
        var outFlight = comboBoxOut.SelectedItem as Airport;
        var inFlight = comboBoxIn.SelectedItem as Airport;
        var airplane = comboBox1.SelectedItem as Airplane;
        var date = (DateTime)comboBoxDate.SelectedItem!;
        inFlight.Count++;
        var newDest = new Destination( /*airplane.id,*/ outFlight.id /*, inFlight.id*/,
            (byte)(inFlight.Distance / airplane.Speed * 2), date);
        if (airplane.MaxDistance < inFlight.Distance)
        {
            MessageBox.Show(
                "Максимальное расстояние выбранного самолета должно быть меньше расстояния точки назначения!",
                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        context.Destinations.Add(newDest);
        context.SaveChanges();
        MessageBox.Show("Успешно!");
        mainForm.InitializeTables();
        Hide();
    }
}