namespace TDMPW_2P_PR02;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void btn0_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 0;
        calcular();
    }

    void btn11_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 11;
        calcular();
    }

    void btn16_Clicked(System.Object sender, System.EventArgs e)
    {
        sld1.Value = 16;
        calcular();
    }

    void entryMonto_TextChanged(System.Object sender, Microsoft.Maui.Controls.TextChangedEventArgs e)
    {
        calcular();
    }

    private void calcular()
    {
        if (double.TryParse(entryMonto.Text, out double monto))
        {
            double envio = 0;
            double iva = 0;

            if (monto <= 100)
            {
                envio = 200;
            }
            else if (monto > 100 && monto <= 300)
            {
                envio = 100;
            }

            if (sld1.Value == 11)
            {
                iva = monto * 0.11;
            }
            else if (sld1.Value == 16)
            {
                iva = monto * 0.16;
            }

            double total = monto + envio + iva;

            // Formatea el total como moneda
            lblTotal.Text = total.ToString("C");
            lblEnvio.Text = envio.ToString("C");
            lblIVA.Text = iva.ToString("C");
        }
        else
        {
            lblTotal.Text = "$0.00";
            lblEnvio.Text = "$0.00";
            lblIVA.Text = "$0.00";
        }
    }
}