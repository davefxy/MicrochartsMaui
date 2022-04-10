using MicrochartsSample.Models;

namespace MicrochartsSample;

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
        ExampleChartItem exChartItem = frame.BindingContext as ExampleChartItem;
        await Navigation.PushAsync(new ChartPage(exChartItem));
        //await Shell.Current.GoToAsync(nameof(ChartPage), true, new Dictionary<string, object>
        //{
        //    {"ExampleChartItem", exChartItem }
        //});
    }
}