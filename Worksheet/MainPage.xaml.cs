using System.Collections.ObjectModel;

namespace Worksheet;

public partial class MainPage : ContentPage
{
    ObservableCollection<WorkSheet> Worksheets = new();

    public MainPage()
    {
        InitializeComponent();

        BrandPicker.ItemsSource = Enum.GetValues<Brands>();
        CreateDate.MinimumDate = DateTime.Now.AddYears(-1);
        CreateDate.MaximumDate = DateTime.Now;
        CreateDate.Date = DateTime.Now;

        Worksheets.Add(new WorkSheet {
            Brand = Brands.Audi, LicensePlate = "AAA111", Id = 1, OdoMeter = 20000 });
        WorkList.ItemsSource = Worksheets;
    }

    private void OnSaveClicked(object sender, EventArgs e)
    {
        var newWorksheet = new WorkSheet();
        newWorksheet.Brand = (Brands)BrandPicker.SelectedItem;
        newWorksheet.OdoMeter = int.Parse(Odometer.Text);
        newWorksheet.LicensePlate = LicensePlate.Text;

        Worksheets.Add(newWorksheet);
    }
}