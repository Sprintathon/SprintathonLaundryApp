using SprintathonLaundryApp.Views;

namespace SprintathonLaundryApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(LogInView), typeof(LogInView));
		Routing.RegisterRoute(nameof(SignUp), typeof(SignUp));
		Routing.RegisterRoute(nameof(ForgotPassword), typeof(ForgotPassword));
		Routing.RegisterRoute(nameof(EnterOtp), typeof(EnterOtp));
        Routing.RegisterRoute(nameof(CreatePasswordView), typeof(CreatePasswordView));
        Routing.RegisterRoute(nameof(CreateOrderView), typeof(CreateOrderView));
        Routing.RegisterRoute(nameof(PlaceOrderView), typeof(PlaceOrderView));
        Routing.RegisterRoute(nameof(OrderSummaryView), typeof(OrderSummaryView));
        Routing.RegisterRoute(nameof(OrderHistoryView), typeof(OrderHistoryView));
    }
}
