namespace TDMPW_2P_PR04;

public partial class MainPage : ContentPage
{
    List<string> images = new List<string>
        {
            "n1.jpeg",
            "n2.jpeg",
            "n3.jpeg",
            "n4.jpeg",
            "n5.jpeg",
        };

    private List<(string Question, string Answer)> questions;
    private Random random;
    private int score;
    private int errors;
    private int attempts;
    private int questionsShown;
    private Label lblPoints;
    private Label lblErrors;


    public MainPage()
	{
		InitializeComponent();
        random = new Random();
        lblPoints = this.FindByName<Label>("lbPuntos");
        lblErrors = this.FindByName<Label>("lbErrores");


        questions = new List<(string Question, string Answer)>
            {
                ("¿Cuál es la capital de España?", "Madrid"),
                ("¿Qué planeta es conocido como el Planeta Rojo?", "Marte"),
                ("¿En qué año comenzó la Segunda Guerra Mundial?", "1939"),
                ("¿Quién escribió Don Quijote de la Mancha?", "Miguel de Cervantes"),
                ("¿Cuál es el río más largo del mundo?", "Amazonas"),
                ("¿Qué elemento químico tiene el símbolo H?", "Hidrógeno"),
                ("¿Cuál es la montaña más alta del mundo?", "Everest"),
                ("¿En qué país se encuentra la ciudad de Machu Picchu?", "Perú"),
                ("¿Qué animal es conocido como el Rey de la Selva?", "León"),
                ("¿Cuántos días tiene el mes de febrero en un año bisiesto?", "29"),
            };

        ShowRandomQuestion();
    }

    private void ShowRandomQuestion()
    {
        if (questionsShown == 5)
        {
            EndGame();
            return;
        }

        var randomQuestion = questions[random.Next(questions.Count)];
        lbPregunta.Text = randomQuestion.Question;

        attempts = 0;
        questionsShown++;
    }

    void btnSiguiente_Clicked(System.Object sender, System.EventArgs e)
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
        int imageIndex = random.Next(images.Count);
        FileImageSource newImageSource = new FileImageSource
        {
            File = images[imageIndex]
        };
        imgPrincipal.Source = newImageSource;

        if (lbRespuesta.Text == null) return;

        if (lbRespuesta.Text.Equals(questions.First(q => q.Question == lbPregunta.Text).Answer, StringComparison.OrdinalIgnoreCase))
        {
            score++;
            UpdateUI();
            lbRespuesta.Text = string.Empty;

            if (score == 3 || questionsShown == 5)
            {
                EndGame();
                return;
            }
            ShowRandomQuestion();
        }
        else
        {
            attempts++;

            if (attempts == 2)
            {
                errors++;
                UpdateUI();
                lbRespuesta.Text = string.Empty;
                ShowRandomQuestion();
            }
            else
            {
                lbRespuesta.Text = string.Empty;
            }
        }
    }

    private void EndGame()
    {
        if (score >= 3)
        {
            DisplayAlert("¡Has ganado!", "Felicitaciones por obtener 3 o más puntos.", "Nueva partida");
        }
        else if (questionsShown == 5)
        {
            DisplayAlert("Has perdido", "No alcanzaste los 3 puntos necesarios en 5 preguntas.", "Nueva partida");
        }

        score = 0;
        errors = 0;
        questionsShown = 0;
        UpdateUI();
        ShowRandomQuestion();
    }

    private void UpdateUI()
    {
        lblPoints.Text = $"Puntos: {score}";
        lblErrors.Text = $"Errores: {errors}";
    }

    void lbRespuesta_Completed(System.Object sender, System.EventArgs e)
    {
        btnSiguiente_Clicked(btnSiguiente, e);
    }
}