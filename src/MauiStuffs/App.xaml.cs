using Microsoft.Maui.Controls;

namespace MauiStuffs;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
