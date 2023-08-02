namespace Nav_V1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(TwoPage), typeof(TwoPage));
    }
}
