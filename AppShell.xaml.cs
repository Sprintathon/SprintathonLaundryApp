using SprintathonLaundryApp.Views;

namespace SprintathonLaundryApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LogInView), typeof(LogInView));
		Routing.RegisterRoute(nameof(SignUp), typeof(SignUp));
    }
}
