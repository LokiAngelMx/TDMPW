namespace TDMPW_2P_EJ01;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void btnCambiar_Clicked(System.Object sender, System.EventArgs e)
    {
		var brush = new SolidColorBrush(
            Color.FromRgb(
                (byte)sldR.Value,
                (byte)sldG.Value,
                (byte)sldB.Value)
            );
        pintar(brush);
    }

    void generarColor()
    {
        var rnd = new Random();
        int r = rnd.Next(0, 256);
        int g = rnd.Next(0, 256);
        int b = rnd.Next(0, 256);
        var brush = new SolidColorBrush(
            Color.FromRgb(
                (byte)r,
                (byte)g,
                (byte)b
                )
            );
        sldR.Value = r;
        sldG.Value = g;
        sldB.Value = b;
        pintar(brush);
    }

    void pintar(SolidColorBrush brush)
    {
        this.background.Background = brush;
        lblResultado.Text = brush.Color.ToHex();
        bxvVista.Color = brush.Color;
    }

    void btnRandom_Clicked(System.Object sender, System.EventArgs e)
    {
        generarColor();
    }

    async void btnCopiar_Clicked(System.Object sender, System.EventArgs e)
    {
        await Clipboard.SetTextAsync(lblResultado.Text);
    }
}