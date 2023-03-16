using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace PaTsa.Conference.App.Maui;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
