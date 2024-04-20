using System.ComponentModel.Design;

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
        var airplanes = context.Airplanes.Where(x => x.isFree).ToArray();
        var airportsIn = context.Airports.ToArray();
        comboBox1.Items.AddRange(airplanes);
        comboBoxOut.Items.AddRange(airportsIn);
        comboBoxIn.Items.AddRange(airportsIn);
        var maxDate = context.Destinations.Select(x => x.FlightDate).Max();
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
            Свободен = pl.isFree
        });
        var result = query.ToList();
        dataGridViewAirplanes.DataSource = result;

        var query2 = context.Airports.Select(port => new
        {
            Название = port.name,
            ИНН = port.INN,
            Адрес = port.address
        });
        var result2 = query2.ToList();
        dataGridViewAirports.DataSource = result2;

        var query3 = context.Positions.Select(pos => new
        {
            Должность = pos.name
        });
        var result3 = query3.ToList();
        dataGridViewPositions.DataSource = result3;

        var query4 = context.Personal.Select(e => new
        {
            ФИО = e.fullname,
            ИНН = e.INN,
            Должность = e.position,
            Служба = e.Service.name,
            Аэропорт = e.Airport.name
        });
        var result4 = query4.ToList();
        dataGridViewPersonal.DataSource = result4;

        var query5 = context.Services.Select(e => new
        {
            Служба = e.name,
        });
        var result5 = query5.ToList();
        dataGridViewServices.DataSource = result5;
    }

    private void Add(object sender, EventArgs e)
    {
        var outFlight = comboBoxOut.SelectedItem as Airport;
        var inFlight = comboBoxIn.SelectedItem as Airport;
        var airplane = comboBox1.SelectedItem as Airplane;
        var date = (DateTime)comboBoxDate.SelectedItem!;
        if (outFlight.address == inFlight.address)
            throw new ArgumentException("Города должны отличаться!");
        var newDest = new Destination(airplane.id, outFlight.id, inFlight.id, 10, date);
        context.Destinations.Add(newDest);
        context.SaveChanges();
        MessageBox.Show("Успешно!");
        mainForm.InitializeTables();
        Hide();
    }
}
