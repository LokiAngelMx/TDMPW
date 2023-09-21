namespace TDMPW_1P_PR02;

public partial class celcius : ContentPage
{
	double grados = 0;
	double resultado = 0;

	public celcius()
	{
		InitializeComponent();
	}

    void btnCelcius_Clicked(System.Object sender, System.EventArgs e)
    {
        grados = double.Parse(this.txtCelcius.Text);
        resultado = grados + 273.15;

        this.txtResultadoKelvin.Text = "Kelvin: " + Math.Round(resultado, 2).ToString();

        grados = double.Parse(this.txtCelcius.Text);
        resultado = (grados * 9 / 5) + 32;

        this.txtResultadoFahrenheit.Text = "Fahrenheit: " + Math.Round(resultado, 2).ToString();
    }
}