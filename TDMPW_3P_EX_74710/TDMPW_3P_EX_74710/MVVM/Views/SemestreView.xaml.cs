using TDMPW_3P_EX_74710.MVVM.ViewModels;

namespace TDMPW_3P_EX_74710.MVVM.Views;

public partial class SemestreView : ContentPage
{
	public SemestreView()
	{
		InitializeComponent();
        BindingContext = new SemestreViewModel();
    }
}