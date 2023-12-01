using ProgressTest2023.ViewModel;
namespace ProgressTest2023;

public partial class MainPage : ContentPage
{
    private MainViewModel _viewModel;

    public MainPage()
    {
        InitializeComponent();

        _viewModel = new MainViewModel();
        BindingContext = _viewModel;
    }


}

