using MabbitBMICalc.Pages;
using MabbitBMICalc.ViewModels;
using Microsoft.Extensions.Logging;

namespace MabbitBMICalc;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("FiraSans-Bold.ttf", "FiraSansBold");
				fonts.AddFont("FiraSans-ExtraBold.ttf", "FiraSansExtraBold");
				fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FAIcons");
			});

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddSingleton<MainViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
