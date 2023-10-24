namespace TDMPW_2P_EX_74710;

public partial class MainPage : TabbedPage
{
    double precio = 0.0;
    double total = 0.0;

	public MainPage()
	{
		InitializeComponent();
	}

    void imgCroissant_Clicked(System.Object sender, System.EventArgs e)
    {
        lbNombre.Text = "Croissant de Mantequilla";
        imgProducto.Source = "croissant.png";
        lbTamano.Text = "Único";
        lbCalorias.Text = "30 calorías";
        lbLeche.Text = "Sin leche";
        lbPrecio.Text = "- $ 60.00";
        precio = 60.00;
        stpCantidad.Value = 1;
    }

    void imgCaramel_Clicked(System.Object sender, System.EventArgs e)
    {
        lbNombre.Text = "Caramel Macchiato";
        imgProducto.Source = "caramel.png";
        lbTamano.Text = "Mediano (13oz - 368ml)";
        lbCalorias.Text = "35 calorías";
        lbLeche.Text = "Leche entera";
        lbPrecio.Text = "- $ 55.00";
        precio = 55.00;
        stpCantidad.Value = 1;
    }

    void imgChessecake_Clicked(System.Object sender, System.EventArgs e)
    {
        lbNombre.Text = "Cheesecake Roulet";
        imgProducto.Source = "cheesecake.png";
        lbTamano.Text = "Único";
        lbCalorias.Text = "25 calorías";
        lbLeche.Text = "Sin leche";
        lbPrecio.Text = "- $ 50.00";
        precio = 50.00;
        stpCantidad.Value = 1;
    }

    void stpCantidad_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        double newValue = e.NewValue;
        lbCantidad.Text = newValue.ToString();
        total = precio * stpCantidad.Value;
        lbTotal.Text = "Total.......................................$ " + total.ToString();
    }
}