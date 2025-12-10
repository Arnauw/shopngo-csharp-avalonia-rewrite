namespace Shopngo.Shared;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0.00m;
    public Rating Rating { get; set; } = new Rating();
}

public class Rating
{
    public decimal Rate { get; set; }
    public int Count { get; set; }
}