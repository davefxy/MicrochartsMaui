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
    //protected void GenerateDynamicData()
    //{
    //    Random r = new((int)DateTime.Now.Ticks);
    //    LineChart lc = (LineChart)chartView.Chart;

    //    int ticks = (int)(250 * TimeSpan.TicksPerMillisecond);

    //    var series = lc.Series;

    //    int rMax = (int)(lc.MinValue + (lc.MaxValue - lc.MinValue) * 0.66f);
    //    int rMin = (int)(lc.MinValue + (lc.MaxValue - lc.MinValue) * 0.33f);
    //    foreach (var s in series)
    //    {
    //        int count = s.Entries.Count();
    //        DelayTimer timer = Microcharts.Timer.Create() as DelayTimer;
    //        timer.Start(new TimeSpan(ticks), () =>
    //        {
    //            Application.Current?.Dispatcher.Dispatch( () =>
    //            {
    //                try
    //                {
    //                    var label = DateTime.Now.ToString("mm:ss");

    //                    int idx = 0;
    //                    foreach (var curSeries in series)
    //                    {
    //                        var entries = curSeries.Entries.ToList();
    //                        bool addLabel = (entries.Count % 1000) == 0;

    //                        if (s == curSeries)
    //                        {
    //                            var entry = Data.GenerateTimeSeriesEntry(r, idx, 1);
    //                            if (!addLabel) entry.First().Label = null;

    //                            entries.AddRange(entry);

    //                            if (entries.Count > count * 1.5) entries.RemoveAt(0);
    //                        }
    //                        else
    //                        {
    //                            var entry = new ChartEntry(null) { ValueLabel = null, Label = label };
    //                            if (!addLabel) entry.Label = null;

    //                            entries.Add(entry);
    //                            if (entries.Count > count * 1.5) entries.RemoveAt(0);
    //                        }

    //                        curSeries.Entries = entries;
    //                        idx++;
    //                    }

    //                    if (!lc.IsAnimating)
    //                    {
    //                        lc.IsAnimated = false;
    //                        lc.Series = series;
    //                        if (!IsDrawing)
    //                        {
    //                            IsDrawing = true;
    //                            chartView.InvalidateSurface();
    //                        }
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //                    Console.WriteLine(ex.Message);
    //                }
    //            });
    //            return Running;
    //        });
    //        ticks += (int)(250 * TimeSpan.TicksPerMillisecond);
    //    }
    //}

    //protected override void OnAppearing()
    //{
    //    base.OnAppearing();

    //    chartView.Chart = vm.ExampleChartItem.Chart;
    //    chartView.ChartPainted += (sender, args) =>
    //    {
    //        IsDrawing = false;
    //    };

    //    if (!chartView.Chart.IsAnimating)
    //        chartView.Chart.AnimateAsync(true).ConfigureAwait(false);

    //    if (vm.ExampleChartItem.IsDynamic && (chartView.Chart as LineChart) != null)
    //    {
    //        GenerateDynamicData();
    //    }
    //}
}