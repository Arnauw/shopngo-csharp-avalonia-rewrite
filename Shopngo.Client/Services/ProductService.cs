using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Shopngo.Shared;

namespace Shopngo.Client.Services;

public class ProductService
{
    private readonly HttpClient _httpClient;

    public ProductService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<List<Product>>("https://fakestoreapi.com/products");
        return response ?? new List<Product>();
    }
    
}