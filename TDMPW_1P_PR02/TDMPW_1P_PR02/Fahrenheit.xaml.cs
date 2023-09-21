namespace TDMPW_1P_PR02;

public partial class Fahrenheit : ContentPage
{
    double grados = 0;
    double resultado = 0;

    public Fahrenheit()
	{
		InitializeComponent();
	}

    void btnFahrenheit_Clicked(System.Object sender, System.EventArgs e)
    {
        grados = double.Parse(this.txtFahrenheit.Text);
        resultado = (grados - 32) * 5 / 9;

        this.txtResultadoCelcius.Text = "Celcius: " + Math.Round(resultado, 2).ToString();

        grados = double.Parse(this.txtFahrenheit.Text);
        resultado = (grados - 32) * 5 / 9 + 273.15;

        this.txtResultadoKelvin.Text = "Kelvin: " + Math.Round(resultado, 2).ToString();
    }
}