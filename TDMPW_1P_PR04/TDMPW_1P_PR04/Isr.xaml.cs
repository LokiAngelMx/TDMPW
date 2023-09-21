namespace TDMPW_1P_PR04;

public partial class Isr : ContentPage
{
    double monto = 0;
    double resultadoISR = 0;

    public Isr()
	{
		InitializeComponent();
	}

    void btnConvertir_Clicked(System.Object sender, System.EventArgs e)
    {
        monto = double.Parse(this.txtMonto.Text);
        resultadoISR = monto * 0.75;

        this.txtResultado.Text = "El resultado es: " + Math.Round(resultadoISR, 2).ToString();
    }
}
