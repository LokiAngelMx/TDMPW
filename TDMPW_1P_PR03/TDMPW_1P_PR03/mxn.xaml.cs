namespace TDMPW_1P_PR03;

public partial class mxn : ContentPage
{
    double cantidad = 0;
    double resultado = 0;

    public mxn()
	{
		InitializeComponent();
	}

    void btnMxn_Clicked(System.Object sender, System.EventArgs e)
    {
        cantidad = double.Parse(this.txtMxn.Text);
        resultado = cantidad * 0.059;

        this.txtResultadoUsd.Text = "USD: " + Math.Round(resultado, 3).ToString();

        cantidad = double.Parse(this.txtMxn.Text);
        resultado = cantidad * 0.054;

        this.txtResultadoEur.Text = "EUR: " + Math.Round(resultado, 3).ToString();
    }
}
