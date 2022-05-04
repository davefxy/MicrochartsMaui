namespace MicrochartsSample.Pages;

public partial class ChartConfigurationPage : ContentPage
{
    public ChartConfigurationPage(string chartType)
    {
        Items = Data.CreateXamarinExampleChartItem(chartType).ToList();
        InitializeComponent();
        Title = chartType;
    }

    public List<ExampleChartItem> Items { get; }

    private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        Frame frame = (sender as Frame);
        ExampleChartItem exampleChartItem = frame.BindingContext as ExampleChartItem;
        try
        {
            //await Navigation.PushAsync(new ChartPage(exChartItem));
            await Shell.Current.GoToAsync(nameof(ChartPage), true, new Dictionary<string, object>
            {
                {"ExampleChartItem", exampleChartItem }
            });
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.ToString());
        }
    }
}