namespace TDMPW_1P_PR03;

public partial class eur : ContentPage
{
    double cantidad = 0;
    double resultado = 0;

    public eur()
	{
		InitializeComponent();
	}

    void btnEur_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.txtEur.Text);
        resultado = cantidad * 18.55;

        this.txtResultadoMxn.Text = "MXN: " + Math.Round(resultado, 3).ToString();

        cantidad = double.Parse(this.txtEur.Text);
        resultado = cantidad * 1.09;

        this.txtResultadoUsd.Text = "USD: " + Math.Round(resultado, 3).ToString();
    }
}
