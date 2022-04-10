namespace MicrochartsSample;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ChartPage), typeof(ChartPage));
	}
}