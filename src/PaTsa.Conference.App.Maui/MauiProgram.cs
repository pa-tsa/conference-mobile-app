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
                fonts.AddFont("SourceSansPro-Black.ttf");
                fonts.AddFont("SourceSansPro-BlackItalic.ttf");
                fonts.AddFont("SourceSansPro-Bold.ttf");
                fonts.AddFont("SourceSansPro-BoldItalic.ttf");
                fonts.AddFont("SourceSansPro-ExtraLight.ttf");
                fonts.AddFont("SourceSansPro-ExtraLightItalic.ttf");
                fonts.AddFont("SourceSansPro-Italic.ttf");
                fonts.AddFont("SourceSansPro-Light.ttf");
                fonts.AddFont("SourceSansPro-LightItalic.ttf");
                fonts.AddFont("SourceSansPro-Regular.ttf");
                fonts.AddFont("SourceSansPro-SemiBold.ttf");
                fonts.AddFont("SourceSansPro-SemiBoldItalic.ttf");
            });

        builder.Services.AddSingleton<ConferenceEventService>();

        builder.Services.AddSingleton<ScheduleViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<SchedulePage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
