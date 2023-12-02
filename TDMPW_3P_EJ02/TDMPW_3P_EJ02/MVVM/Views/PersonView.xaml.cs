using TDMPW_3P_EJ02.MVVM.ViewModels;

namespace TDMPW_3P_EJ02.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		BindingContext = new PersonViewModel();
	}
}