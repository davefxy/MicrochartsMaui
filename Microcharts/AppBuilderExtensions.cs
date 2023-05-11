using Microsoft.Maui.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace Microcharts;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMicrocharts(this MauiAppBuilder builder)
    {
        builder.UseSkiaSharp();

        return builder;
    }
}
