using TDMPW_3P_EX_74710.MVVM.ViewModels;

namespace TDMPW_3P_EX_74710.MVVM.Views;

public partial class MateriaView : ContentPage
{
	public MateriaView()
	{
		InitializeComponent();
        BindingContext = new MateriaViewModel();
    }
}