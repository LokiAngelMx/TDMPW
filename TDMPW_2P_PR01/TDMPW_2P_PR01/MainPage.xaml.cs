namespace TDMPW_2P_PR01;

public partial class MainPage : TabbedPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    private void entryNombre_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = e.NewTextValue;
        labelNombre.Text = $"{nombre}";
    }
    private void entryNombre2_TextChanged(object sender, TextChangedEventArgs e)
    {
        string nombre = e.NewTextValue;
        labelNombre1.Text = $"{nombre}";
    }
    private void SwitchToggled(object sender, ToggledEventArgs e)
    {
        bool isSwitchOn = e.Value;
        sliderControl.IsEnabled = !isSwitchOn;
        stepperControl.IsEnabled = isSwitchOn;
    }
    private void stepperControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderControl.Value = e.NewValue;
    }
    private void sliderControl_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double sliderValue = Math.Round(e.NewValue);
        labelValue.Text = sliderValue.ToString("0.0");
    }
}