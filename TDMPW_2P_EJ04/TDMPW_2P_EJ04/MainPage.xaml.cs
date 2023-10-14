using System.ComponentModel;

namespace TDMPW_2P_EJ04;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
    private int count = 0;
    private string status = "HOLA";
    private string spotLight = "_ _ _";
    private List<char> letters = new List<char>();
    private string message = "Mensaje";
    private int mistakes = 0;
    private int maxWrong = 5;
    private string currentImage = "dotnet_bot.png";
    private string answer = "";
    private List<char> guessed = new List<char>();

    public int Count
    {
        get => Count;
        set
        {
            count = value;
            OnPropertyChanged();
        }
    }

    public string Status
    {
        get => status;
        set
        {
            status = value;
            OnPropertyChanged();
        }
    }

    public string SpotLight
    {
        get => spotLight;
        set
        {
            spotLight = value;
            OnPropertyChanged();
        }
    }

    public List<char> Letters
    {
        get => letters;
        set
        {
            letters = value;
            OnPropertyChanged();
        }
    }

    public string Message
    {
        get => message;
        set
        {
            message = value;
            OnPropertyChanged();
        }
    }

    public string CurrentImage
    {
        get => currentImage;
        set
        {
            currentImage = value;
            OnPropertyChanged();
        }
    }

    List<string> words = new List<string>()
    {
        "MAUI",
        "XAML",
        "CGATITO",
        "SQL",
        "FHP",
    };

    public MainPage()
	{
		InitializeComponent();
        Letters.AddRange("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ");
		BindingContext = this;
        Pickword();
        CalcularPalabra(answer, guessed);
	}

    private void Pickword()
    {
        answer = words[new Random().Next(0, words.Count)];
    }

    private void CalcularPalabra(string answer, List<char> guessed)
    {
        var temp = answer.Select(x => (guessed.IndexOf(x) >= 0 ? x : '_')).ToArray();
        SpotLight = string.Join(' ', temp);
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		Status = "HOLA " + count;
	}

    void btnReiniciar_Clicked(System.Object sender, System.EventArgs e)
    {
        mistakes = 0;
        guessed = new List<char>();
        Message = "";
        CurrentImage = "dotnet_bot.png";
        Pickword();
        CalcularPalabra(answer, guessed);
        actualizarStatus();
        habilitarLetras();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        var btn = sender as Button;
        if(btn != null)
        {
            var letter = btn.Text;
            btn.IsEnabled = false;
            HandleGuess(letter[0]);
        }
    }

    private void HandleGuess(char letter)
    {
        if(guessed.IndexOf(letter) == -1)
        {
            guessed.Add(letter);
        }
        if(answer.IndexOf(letter) >= 0)
        {
            CalcularPalabra(answer, guessed);
            ganado();
        }
        else if(answer.IndexOf(letter) == -1)
        {
            mistakes++;
            actualizarStatus();
            perdido();
        }
    }

    private void perdido()
    {
        if(mistakes == maxWrong)
        {
            Message = "VALES VRG!";
            deshabilitarLetras();
        }
    }

    private void ganado()
    {
        if(SpotLight.Replace(" ", "") == answer)
        {
            Message = "ERES UNA VRG!";
            deshabilitarLetras();
        }
    }

    private void deshabilitarLetras()
    {
        foreach(var c in Contenedor.Children)
        {
            var btn = c as Button;
            if(btn != null)
            {
                btn.IsEnabled = false;
            }
        }
    }

    private void habilitarLetras()
    {
        foreach (var c in Contenedor.Children)
        {
            var btn = c as Button;
            if (btn != null)
            {
                btn.IsEnabled = true;
            }
        }
    }

    private void actualizarStatus()
    {
        Status = $"Errores: {mistakes} de {maxWrong}";
    }
}