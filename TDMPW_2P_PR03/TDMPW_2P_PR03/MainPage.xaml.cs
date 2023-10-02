namespace TDMPW_2P_PR03;

public partial class MainPage : ContentPage
{
    List<string> frases = new List<string>();
    List<string> images = new List<string>
        {
            "n1.jpeg",
            "n2.jpeg",
            "n3.jpeg",
            "n4.jpeg",
            "n5.jpeg",
        };

    string ToHex(System.Drawing.Color color)
    {
        return $"#{color.R:X2}{color.G:X2}{color.B:X2}";
    }

    public MainPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("frases.txt");
        using var reader = new StreamReader(stream);

        while (reader.Peek() != -1)
        {
            frases.Add(reader.ReadLine());
        }
    }

    Random random = new Random();

    void btnGenerar_Clicked(System.Object sender, System.EventArgs e)
    {
        var startColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256)
            );

        var endColor = System.Drawing.Color.FromArgb(
            random.Next(0, 256),
            random.Next(0, 256),
            random.Next(0, 256)
            );

        var colors = ColorUtility.ColorControls.GetColorGradient(startColor, endColor, 6);

        float stopOffset = 0.0f;

        var stops = new GradientStopCollection();

        foreach (var c in colors)
        {
            stops.Add(new GradientStop(Color.FromArgb(c.Name), stopOffset));
            stopOffset += 0.2f;
        }

        var gradient = new LinearGradientBrush(stops, new Point(0, 0), new Point(1, 1));

        background.Background = gradient;
        int index = random.Next(frases.Count);
        frase.Text = frases[index];
        int imageIndex = random.Next(images.Count);
        FileImageSource newImageSource = new FileImageSource
        {
            File = images[imageIndex]
        };
        imgPrincipal.Source = newImageSource;

        color1.Text = ToHex(colors[0]);
        color2.Text = ToHex(colors[1]);
        color3.Text = ToHex(colors[2]);
        color4.Text = ToHex(colors[3]);
        color5.Text = ToHex(colors[4]);
        color6.Text = ToHex(colors[5]);
    }
}