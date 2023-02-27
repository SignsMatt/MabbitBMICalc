using MabbitBMICalc.ViewModels;

namespace MabbitBMICalc.Pages;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

