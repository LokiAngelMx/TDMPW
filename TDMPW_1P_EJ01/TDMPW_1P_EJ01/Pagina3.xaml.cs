namespace TDMPW_1P_EJ01;

public partial class Pagina3 : ContentPage
{
	double monto = 0;
	double resultado = 0;

	public Pagina3()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		monto = double.Parse(this.txtMonto.Text);
		resultado = monto * 1.16;

		this.txtResultado.Text = "Resultado: " + resultado.ToString();

    }
}
