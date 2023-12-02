using TDMPW_3P_EJ02.MVVM.Views;

namespace TDMPW_3P_EJ02;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PersonView();
	}
}