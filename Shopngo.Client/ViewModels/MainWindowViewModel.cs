using CommunityToolkit.Mvvm.ComponentModel;

namespace Shopngo.Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _currentViewModel;

    public MainWindowViewModel()
    {
        _currentViewModel = new HomeViewModel();
    }
}