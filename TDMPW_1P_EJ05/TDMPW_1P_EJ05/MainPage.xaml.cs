namespace TDMPW_1P_EJ05;

public partial class MainPage : TabbedPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void btnSaludar_Clicked(System.Object sender, System.EventArgs e)
    {
		this.lblSaludar.Text = "¡Te saludo!";
    }
}


