using TDMPW_3P_EX_74710.MVVM.Views;

namespace TDMPW_3P_EX_74710;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}