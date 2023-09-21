namespace TDMPW_1P_PR03;

public partial class usd : ContentPage
{
    double cantidad = 0;
    double resultado = 0;

    public usd()
	{
		InitializeComponent();
	}

    void btnUsd_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.txtUsd.Text);
        resultado = cantidad * 17.06;

        this.txtResultadoMxn.Text = "MXN: " + Math.Round(resultado, 3).ToString();

        cantidad = double.Parse(this.txtUsd.Text);
        resultado = cantidad * 0.92;

        this.txtResultadoEur.Text = "EUR: " + Math.Round(resultado, 3).ToString();
    }
}
