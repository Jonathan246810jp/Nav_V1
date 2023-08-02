using Nav_V1.ViewModel;


namespace Nav_V1;

public partial class MainPage : ContentPage
{
    public MainPage(ViewModels vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }


}

