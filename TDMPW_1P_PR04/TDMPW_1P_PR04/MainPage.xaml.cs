namespace TDMPW_1P_PR04;

public partial class MainPage : FlyoutPage
{

	public MainPage()
	{
		InitializeComponent();
	}

    void btnIVA_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Iva());
    }

    void btnISR_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new Isr());
    }
}