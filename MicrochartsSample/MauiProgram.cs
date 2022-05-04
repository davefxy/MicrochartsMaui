using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MicrochartsSample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseSkiaSharp(true)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
		builder.Services.AddSingleton<ChartConfigurationPage>();

		builder.Services.AddTransient<ChartPage>();
		builder.Services.AddTransient<ChartViewModel>();

		return builder.Build();
	}
}
