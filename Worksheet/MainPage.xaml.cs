namespace Worksheet
{
    public partial class MainPage : ContentPage
    {
        List<WorkSheet> worksheets;

        public MainPage()
        {
            InitializeComponent();

            BrandPicker.ItemsSource = Enum.GetValues<Brands>();
            CreateDate.MinimumDate = DateTime.Now.AddYears(-1);
            CreateDate.MaximumDate = DateTime.Now;
            CreateDate.Date = DateTime.Now;
        }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            //TODO: get data from Entries, Pickers
            //TODO: Create new WorkSheet
            //TODO: Add worksheet to workSheets
        }
    }
}