using Microsoft.Maui.Controls;

namespace EmailAuth;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}
