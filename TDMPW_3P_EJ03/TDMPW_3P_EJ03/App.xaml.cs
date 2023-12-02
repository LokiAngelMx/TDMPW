namespace TDMPW_3P_EJ03;
using TDMPW_3P_EJ03.MVVM.Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DolarView();
	}
}