namespace TDMPW_1P_PR01;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void PaginaImpuestos_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Impuestos());
    }
}