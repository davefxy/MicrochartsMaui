I took the source from original project project at (https://github.com/microcharts-dotnet/Microcharts) because I wanted t create a simple smaller Maui version.
I made a version explicitly for Net 6.0 and Net 7.0. Keeping its dependency on Skia but pretty much removing all else.
You can build this version as a nuget and load it locally. Or just include the project with your solution. It should work with any Net 7.0 and Net 6.0 projects.
I used this as an exercise to learn how to migrate a Xamarin.Forms/ Netstandard 2 version to a Maui version.
I have accomplised what I intended so I am done with it. Don't intend to maintain this in the foreseeable future.
There appears to be another group adding new code to the original github site. That would be the version to look toward for future changes.
# Microcharts

**Microcharts** is an extremely simple charting library for a wide range of platforms (see *Compatibility* section below), with shared code and rendering for all of them!

read our [wiki](https://github.com/dotnet-ad/Microcharts/wiki) to learn more about how to use this library.

## About

This project is just simple drawing on top of the awesome [SkiaSharp](https://github.com/mono/SkiaSharp) library. The purpose is not to have an heavily customizable charting library. If you want so, simply fork the code, since all of this is fairly simple. Their is no interaction, nor animation at the moment.

## Contributions

Contributions are welcome! If you find a bug please report it and if you want a feature please report it.

If you want to contribute code please file an issue and create a branch off of the current dev branch and file a pull request.

More info on how you can help can be found [here](https://github.com/dotnet-ad/Microcharts/wiki/Contributing).

## Compatibility

Built in views are provided for **Net 6.0**, **Net 7.0** [SkiaSharp](https://github.com/mono/SkiaSharp) supported platform is also compatible (see one of the included `ChartView` implementations for more details).

## License

MIT © [Aloïs Deniel](https://aloisdeniel.com) & [Ed Lomonaco](https://edlomonaco.dev)
