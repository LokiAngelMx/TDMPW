namespace TDMPW_1P_PR01;

public partial class Impuestos : ContentPage
{

	double monto = 0;
	double resultado = 0;

	public Impuestos()
	{
		InitializeComponent();
	}

    void ConIva_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtMonto.Text);
        resultado = monto * 1.16;

        this.txtResultado.Text = "Resultado: " + Math.Round(resultado, 2).ToString();
    }

    void SinIva_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtMonto.Text);
        resultado = monto / 1.16;

        this.txtResultado.Text = "Resultado: " + Math.Round(resultado, 2).ToString();
    }
}