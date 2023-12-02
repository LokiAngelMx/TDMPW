namespace TDMPW_3P_EJ03.MVVM.Views;
using TDMPW_3P_EJ03.MVVM.ViewModels;

public partial class DolarView : ContentPage
{
	public DolarView()
	{
		InitializeComponent();
		BindingContext = new DolarViewModel();
	}
}
