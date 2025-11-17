using TDD_Nov.Models;
namespace TDD_Nov.Services;

public class ProductService
{
    private readonly IEnumerable<Product>? _products;

    public ProductService(IEnumerable<Product> products)
    {
        _products = products;
    }

    /// <summary>
    /// Get all available products, by checking whether or not the CurrentlyInStock field is true. If the field is false, the product is not currently available.
    /// </summary>
    /// <returns>List</returns>
    public IEnumerable<Product> GetAvailableProducts()
    {
        return _products!.Where(p => p.CurrentlyInStock);
    }

    public IEnumerable<Product> GetProductsByCategory(string category)
    {
        return _products!.Where(p => p.Category.Equals(category));
    }

    public double GetAveragePrice()
    {
        return _products!.Average(p => p.Price);
    }

    public Product? GetMostExpensiveProduct()
    {
        return _products!.OrderByDescending(p => p.Price).FirstOrDefault();
    }
}