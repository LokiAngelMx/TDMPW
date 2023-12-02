using Microsoft.Maui.Controls;

namespace TDMPW_3P_PR02;

public partial class MainPage : ContentPage
{

    DetailViewModel viewModel = new DetailViewModel();

    string detallesNombrePlatillo = "";
    string detallesCalorias = "";
    string detallesImagen = "";
    string detallesPrecio = "";
    string detallesTipoCocina = "";

    public string DetallesNombrePlatillo
    {
        get => detallesNombrePlatillo;
        set
        {
            detallesNombrePlatillo = value;
            OnPropertyChanged();
        }
    }

    public string DetallesCalorias
    {
        get => detallesCalorias;
        set
        {
            detallesCalorias = value;
            OnPropertyChanged();
        }
    }

    public string DetallesImagen
    {
        get => detallesImagen;
        set
        {
            detallesImagen = value;
            OnPropertyChanged();
        }
    }

    public string DetallesPrecio
    {
        get => detallesPrecio;
        set
        {
            detallesPrecio = value;
            OnPropertyChanged();
        }
    }

    public string DetallesTipoCocina
    {
        get => detallesTipoCocina;
        set
        {
            detallesTipoCocina = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    List<string> platos = new List<string>
    {
        "Ingredient 1",
        "Ingredient 2",
        "Ingredient 3",
        // Add more ingredients here...
    };


    private async void Carrito_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushAsync(new Carrito());
    }

    private async void TapGestureRecognizer_Tapped_1(System.Object sender, EventArgs e)
    {

        string TextoNombrePlatillo = "Desayuno Americano";
        string TextoCalorias = "1500 kcal";
        string TextoImagen = "mc_trio1.png";
        string TextoTipoCocina = "Comida rápida";
        string TextoPrecio = "$150";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_2(System.Object sender, EventArgs e)
    {
        string TextoNombrePlatillo = "Desayuno Gourmet";
        string TextoCalorias = "2000 kcal";
        string TextoImagen = "mc_trio2.png";
        string TextoTipoCocina = "Comida rápida";
        string TextoPrecio = "200";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_3(System.Object sender, EventArgs e)
    {
        string TextoNombrePlatillo = "2 Hamburguesas y jugo";
        string TextoCalorias = "750 kcal";
        string TextoImagen = "mc_trio3.png";
        string TextoTipoCocina = "Comida rápida";
        string TextoPrecio = "$120";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_4(System.Object sender, EventArgs e)
    {

        string TextoNombrePlatillo = "Combo 2 pa 2";
        string TextoCalorias = "800 kcal";
        string TextoImagen = "mc_trio4.png";
        string TextoTipoCocina = "Comida rápida";
        string TextoPrecio = "$140";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_5(System.Object sender, EventArgs e)
    {
        string TextoNombrePlatillo = "3 Molletes";
        string TextoCalorias = "900 kcal";
        string TextoImagen = "mc_trio5.png";
        string TextoTipoCocina = "Cocinado con amor";
        string TextoPrecio = "$90";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_6(System.Object sender, EventArgs e)
    {
        string TextoNombrePlatillo = "Desayuno Godín";
        string TextoCalorias = "600 kcal";
        string TextoImagen = "mc_trio6.png";
        string TextoTipoCocina = "Comida express";
        string TextoPrecio = "$70";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }

    private async void TapGestureRecognizer_Tapped_7(System.Object sender, EventArgs e)
    {
        string TextoNombrePlatillo = "Combo solitario";
        string TextoCalorias = "700 kcal";
        string TextoImagen = "mc_trio7.png";
        string TextoTipoCocina = "Comida express";
        string TextoPrecio = "$80";
        await Navigation.PushAsync(new Detalles(TextoNombrePlatillo, TextoImagen, TextoCalorias, TextoPrecio, TextoTipoCocina));
    }
}