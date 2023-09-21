namespace TDMPW_1P_PR05;

public partial class MainPage : ContentPage
{
    int contador;
	public MainPage()
	{
		InitializeComponent();
	}

    void btn1_Clicked(System.Object sender, System.EventArgs e)
    {
        contador++;

        sld1.Value = sld1.Value + 1;
        if (sld1.Value == 10)
        {
            sld2.Value = sld2.Value + 1;
        }
        if (sld2.Value == 20)
        {
            sld3.Value = sld3.Value + 1;
        }
        if (sld3.Value == 30)
        {
            lblTitle.Text = "¡GANASTE!";
        }

        if (btn1.IsPressed)
        {
            btn1.IsEnabled = false;
            btn2.IsEnabled = true;
            this.lblScore.Text = contador.ToString();

        }
        if (btn2.IsPressed)
        {
            btn1.IsEnabled = true;
            btn2.IsEnabled = false;
            this.lblScore.Text = contador.ToString();
        }

        this.lblScore.Text = contador.ToString();
    }
}