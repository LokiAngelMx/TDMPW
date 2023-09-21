namespace TDMPW_1P_PR03;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void MXN_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new mxn());
    }

    void USD_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new usd());
    }

    void EUR_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new eur());
    }
}