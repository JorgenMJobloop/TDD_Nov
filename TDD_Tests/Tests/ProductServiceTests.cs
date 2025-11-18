using TDD_Nov.Models;
using TDD_Nov.Services;
using Xunit;
public class ProductServiceTests
{
    private readonly ProductService _service;

    public ProductServiceTests()
    {
        var products = new List<Product>
        {
            new Product {Id = 1, Name = "A", Category = "Category1", Price = 5,  CurrentlyInStock = true},
            new Product {Id = 2, Name = "B", Category = "Category1", Price = 10, CurrentlyInStock = true},
            new Product {Id = 3, Name = "C", Category = "Category2", Price = 20, CurrentlyInStock = false}, // the odd one out in test 1
            new Product {Id = 4, Name = "D", Category = "Category1", Price = 30, CurrentlyInStock = true},
            new Product {Id = 5, Name = "E", Category = "Category2", Price = 40, CurrentlyInStock = true},
            new Product {Id = 6, Name = "F", Category = "Category1", Price = 50, CurrentlyInStock = false}
        };
        _service = new ProductService(products);
    }

    // Test 1, in this test we verify that when a product is not in stock, our GetAvailableProducts method does not return the products that are NOT in stock.
    [Fact]
    public void GetAvailableProducts_ShouldOnlyReturnItemsCurrentlyInStock()
    {
        var availableItems = _service.GetAvailableProducts(); // get all the available products listed internally from: var products line 10
        Assert.All(availableItems, prod => Assert.True(prod.CurrentlyInStock));
    }

    [Theory]
    [InlineData("Category1", 4)]
    [InlineData("Category2", 2)]
    public void GetProductsByCategory_ShouldReturnTheCorrectCountOfItems(string category, int expectedItemCount)
    {
        var result = _service.GetProductsByCategory(category); // currently holding each category from : var products in the constructor
        Assert.Equal(expectedItemCount, result.Count());
    }

    [Fact]
    public void GetAveragePrice_ShouldReturnCorrectAverage()
    {
        var average = _service.GetAveragePrice(); // hold our average price
        Assert.Equal(26, Math.Round(average));
    }
}