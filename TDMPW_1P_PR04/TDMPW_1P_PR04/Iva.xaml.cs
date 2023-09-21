namespace TDMPW_1P_PR04;

public partial class Iva : ContentPage
{
    double monto = 0;
    double resultadoISR = 0;

    public Iva()
	{
		InitializeComponent();
	}

    void btnConvertir_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtMonto.Text);
        resultadoISR = monto * 1.16;

        this.txtResultado.Text = "El resultado es: " + Math.Round(resultadoISR, 2).ToString();
    }
}
