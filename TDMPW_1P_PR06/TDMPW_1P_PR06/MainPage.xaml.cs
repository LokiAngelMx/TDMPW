namespace TDMPW_1P_PR06;

public partial class MainPage : TabbedPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Like_Clicked(object sender, EventArgs e)
    {
        this.lblGustaoNo.Text = "Te gustó este personaje";
        this.lblGustaoNo2.Text = "Te gustó este personaje";
    }

    private void Dislike_Clicked(object sender, EventArgs e)
    {
        this.lblGustaoNo.Text = "No te gustó este personaje";
        this.lblGustaoNo2.Text = "No te gustó este personaje";

    }
}