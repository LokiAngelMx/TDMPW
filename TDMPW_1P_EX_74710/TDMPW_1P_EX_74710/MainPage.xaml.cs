namespace TDMPW_1P_EX_74710;

public partial class MainPage : TabbedPage
{
    double amperios = 0;
    double voltios = 0;
    double joules = 0;
    double segundos = 0;
    double resultado = 0;

    public MainPage()
	{
		InitializeComponent();
	}

    void btnCalcular1_Clicked(System.Object sender, System.EventArgs e)
    {
        amperios = double.Parse(this.entAmperios.Text);
        voltios = double.Parse(this.entVoltios.Text);
        resultado = amperios * voltios;

        this.txtResultadoW.Text = "Resultado: " + Math.Round(resultado, 2).ToString();
    }

    void btnCalcular2_Clicked(System.Object sender, System.EventArgs e)
    {
        joules = double.Parse(this.txtJoules.Text);
        segundos = double.Parse(this.txtSegundos.Text);

        resultado = joules / segundos;

        this.txtResultadoP.Text = "Resultado: " + Math.Round(resultado, 2).ToString();
    }
}