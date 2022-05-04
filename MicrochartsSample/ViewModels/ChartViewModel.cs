namespace MicrochartsSample.ViewModels;

[QueryProperty(nameof(Models.ExampleChartItem), "ExampleChartItem")]
public partial class ChartViewModel : BaseViewModel
{
    bool Running = true;
    bool IsDrawing = false;
    public ChartViewModel()
    {
    }

    [ObservableProperty]
    ExampleChartItem exampleChartItem;
    //public ExampleChartItem ExChartItem
    //{
    //    get => ExampleChartItem;
    //    set => SetProperty(ref ExampleChartItem, value);
    //}

    public void GenerateDynamicData()
    {
        Title = ExampleChartItem.ChartType;

        Random r = new((int)DateTime.Now.Ticks);
        LineChart lc = (LineChart)ExampleChartItem.Chart;

        int ticks = (int)(250 * TimeSpan.TicksPerMillisecond);

        var series = lc.Series;

        int rMax = (int)(lc.MinValue + (lc.MaxValue - lc.MinValue) * 0.66f);
        int rMin = (int)(lc.MinValue + (lc.MaxValue - lc.MinValue) * 0.33f);
        foreach (var s in series)
        {
            int count = s.Entries.Count();
            DelayTimer timer = Microcharts.Timer.Create() as DelayTimer;
            timer.Start(new TimeSpan(ticks), () =>
            {
                Application.Current?.Dispatcher.Dispatch(() =>
                {
                    try
                    {
                        var label = DateTime.Now.ToString("mm:ss");

                        int idx = 0;
                        foreach (var curSeries in series)
                        {
                            var entries = curSeries.Entries.ToList();
                            bool addLabel = (entries.Count % 1000) == 0;

                            if (s == curSeries)
                            {
                                var entry = Data.GenerateTimeSeriesEntry(r, idx, 1);
                                if (!addLabel) entry.First().Label = null;

                                entries.AddRange(entry);

                                if (entries.Count > count * 1.5) entries.RemoveAt(0);
                            }
                            else
                            {
                                var entry = new ChartEntry(null) { ValueLabel = null, Label = label };
                                if (!addLabel) entry.Label = null;

                                entries.Add(entry);
                                if (entries.Count > count * 1.5) entries.RemoveAt(0);
                            }

                            curSeries.Entries = entries;
                            idx++;
                        }

                        if (!lc.IsAnimating)
                        {
                            lc.IsAnimated = false;
                            lc.Series = series;
                            if (!IsDrawing)
                            {
                                IsDrawing = true;
                                //chartView.InvalidateSurface();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                });
                return Running;
            });
            ticks += (int)(250 * TimeSpan.TicksPerMillisecond);
        }
    }
}
