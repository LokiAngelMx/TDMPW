using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace TDMPW_3P_PR02;

public partial class Detalles : ContentPage
{
    public Detalles(string TextoNombrePlatillo, string TextoImagen, string TextoCalorias, string TextoPrecio, string TextoTipoCocina)
    {
        InitializeComponent();
        DetallesNombrePlatillo.Text = TextoNombrePlatillo;
        //DetallesImagenPlatillo.Text = TextoImagen;
        DetallesCaloriasPlatillo.Text = TextoCalorias;
        DetallesTipoPlatillo.Text = TextoTipoCocina;
        DetallesPrecioPlatillo.Text = TextoPrecio;


    }

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }

    void stepperIngredienteUno_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        ValorIngredienteUno.Text = e.NewValue.ToString();
    }

    void stepperIngredienteDos_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        ValorIngredienteDos.Text = e.NewValue.ToString();
    }

    void stepperIngredienteTres_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        ValorIngredienteTres.Text = e.NewValue.ToString();
    }

    void stepperIngredienteCuatro_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        ValorIngredienteCuatro.Text = e.NewValue.ToString();
    }

    void stepperIngredienteCinco_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        ValorIngredienteCinco.Text = e.NewValue.ToString();
    }

    void stepperCantidadPlatos_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        CantidadPlato.Text = e.NewValue.ToString();
    }
}