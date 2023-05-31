global using SprintathonLaundryApp.Models;
namespace SprintathonLaundryApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		//This checks is the user had used the app before and if the user did
		//not, the it will automayically move to the log in veiw
        string firstName = Preferences.Default.Get("first_name", "Unknown");
		if (firstName.Equals("Unknown"))
			Shell.Current.GoToAsync($"//LogIn");
		//Otherwise it will act as usual by proceeding to the main view;
    }
}
