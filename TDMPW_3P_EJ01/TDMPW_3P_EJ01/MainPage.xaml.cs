using System.ComponentModel;

namespace TDMPW_3P_EJ01;

public partial class MainPage : ContentPage, INotifyPropertyChanged
{
	int count = 0;
	string mensaje = "Hola te damos la bienvenida";
	string nombreImagen = "dotnet_bot.png";

	public string Mensaje
	{
		get => mensaje;
		set
		{
			mensaje = value;
			OnPropertyChanged();
		}
	}

	public string NombreImagen
	{
		get => nombreImagen;
		set
		{
			nombreImagen = value;
            OnPropertyChanged();
        }
	}

	public MainPage()
	{
		InitializeComponent();
		BindingContext = this;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		if (count == 0)
		{
            NombreImagen = "calabaza.jpeg";
			count++;
        }
		else
		{
			NombreImagen = "dotnet_bot.png";
			count = 0;
		}
	}
}