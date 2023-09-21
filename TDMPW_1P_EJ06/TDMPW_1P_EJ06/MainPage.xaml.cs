namespace TDMPW_1P_EJ06;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    void sld1_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        this.sld1.Value = Math.Round(this.sld1.Value, 0);
        this.lblSlider.Text = this.sld1.Value.ToString();
    }

    void stp1_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        this.lblStp.Text = this.stp1.Value.ToString();
        this.sld1.Value = this.stp1.Value;
    }

    void swt1_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
    {
        if (this.swt1.IsToggled)
            this.lblSwitch.Text = "PRENDIDO";
        if (!this.swt1.IsToggled)
            this.lblSwitch.Text = "APAGADO";
    }
}