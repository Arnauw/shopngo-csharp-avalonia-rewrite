using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Shopngo.Client.Services;
using Shopngo.Shared;

namespace Shopngo.Client.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    private readonly ProductService _productService;

    public ObservableCollection<Product> Products { get; } = new();
    
    [ObservableProperty]
    private bool _isLoading;

    public MainWindowViewModel()
    {
        _productService = new ProductService(new HttpClient());
        LoadProductsCommand.Execute(null);
    }

    [RelayCommand]
    private async Task LoadProducts()
    {
        if (IsLoading) return;

        try
        {
            IsLoading = true;
            Products.Clear();
            var items = await _productService.GetProductsAsync();
            foreach (var item in items)
            {
                Products.Add(item);
            }
        }
        finally
        {
            IsLoading = false;
        }
    }
    
    public string Greeting { get; } = "Welcome to Avalonia!";
}