namespace MicrochartsSample.Pages;

public partial class ChartPage : ContentPage
{
    ChartViewModel vm;
    public ChartPage(ChartViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = vm = viewModel;
    }

    private bool Running = true;

    protected override void OnDisappearing()
    {
        Running = false;
        base.OnDisappearing();
    }
    bool IsDrawing = false;

    protected override void OnAppearing()
    {
        base.OnAppearing();

        chartView.Chart = vm.ExampleChartItem.Chart;

        if (!chartView.Chart.IsAnimating)
            chartView.Chart.AnimateAsync(true).ConfigureAwait(false);
    }
}