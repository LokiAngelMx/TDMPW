namespace TDMPW_1P_PR02;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void Celcius_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new celcius());
    }

    void Fahrenheit_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Fahrenheit());
    }

    void Kelvin_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new kelvin());
    }
}