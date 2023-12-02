using System.Windows.Input;
using TDMPW_3P_EX_74710.MVVM.Views;

namespace TDMPW_3P_EX_74710;

public partial class MainPage : ContentPage
{
    public ICommand NavigateToMateriaViewCommand { get; private set; }
    public ICommand NavigateToSemestreViewCommand { get; private set; }

    public MainPage()
    {
        InitializeComponent();
        NavigateToMateriaViewCommand = new Command(NavigateToMateriaView);
        NavigateToSemestreViewCommand = new Command(NavigateToSemestreView);
        BindingContext = this;
    }

    private async void NavigateToMateriaView()
    {
        await Navigation.PushAsync(new MateriaView());
    }

    private async void NavigateToSemestreView()
    {
        await Navigation.PushAsync(new SemestreView());
    }
}