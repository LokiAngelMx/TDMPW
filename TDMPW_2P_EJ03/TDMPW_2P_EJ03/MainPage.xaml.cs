namespace TDMPW_2P_EJ03;

public partial class MainPage : ContentPage
{
	List<string> frases = new List<string>();

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

        //var contents = reader.ReadToEnd();

		while (reader.Peek() != -1)
		{
			frases.Add(reader.ReadLine());
		}

		//using (StreamReader reader = new StreamReader(stream))
		//{
		//	string line;
		//	while((line = await reader.ReadLineAsync()) != null)
		//	{
		//		frase.ChildAdded(line);
		//	}
		//}
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

		foreach(var c in colors)
		{
			stops.Add(new GradientStop(Color.FromArgb(c.Name), stopOffset));
			stopOffset += 0.2f;
		}

		var gradient = new LinearGradientBrush(stops, new Point(0,0), new Point(1,1));

		background.Background = gradient;
		int index = random.Next(frases.Count);
		frase.Text = frases[index];
		FileImageSource newSource = new FileImageSource
		{
			File = "dotnet_bot.png"
		};
		imgPrincipal.Source = newSource;
    }
}