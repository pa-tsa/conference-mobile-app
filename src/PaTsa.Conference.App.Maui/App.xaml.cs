using Microsoft.Maui.Controls;

namespace PaTsa.Conference.App.Maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
