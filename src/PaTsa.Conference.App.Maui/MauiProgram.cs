using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using PaTsa.Conference.App.Maui.Pages;
using PaTsa.Conference.App.Maui.Services;
using PaTsa.Conference.App.Maui.ViewModels;

namespace PaTsa.Conference.App.Maui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<ConferenceEventService>();

        builder.Services.AddSingleton<ConferenceEventGroupViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<SchedulePage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
