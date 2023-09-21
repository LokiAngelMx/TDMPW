namespace TDMPW_1P_PR02;

public partial class kelvin : ContentPage
{
    double grados = 0;
    double resultado = 0;

    public kelvin()
	{
		InitializeComponent();
	}

    void btnKelvin_Clicked(System.Object sender, System.EventArgs e)
    {
        grados = double.Parse(this.txtKelvin.Text);
        resultado = grados - 273.15;

        this.txtResultadoCelcius.Text = "Celcius: " + Math.Round(resultado, 2).ToString();

        grados = double.Parse(this.txtKelvin.Text);
        resultado = (grados - 273.15) * 9 / 5 + 32;

        this.txtResultadoFahrenheit.Text = "Fahrenheit: " + Math.Round(resultado, 2).ToString();
    }
}