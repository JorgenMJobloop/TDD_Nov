using TDD_Nov.Models;
namespace TDD_Nov.Utilities;
/// <summary>
/// A general data seeding class, that "seeds" data into our models
/// </summary>
public static class DataSeeder
{
    public static void LoopThroughData(List<string> values)
    {
        foreach (var value in values)
        {
            Console.WriteLine($"Values: {value}");
        }

        // using the IEnumerable
        values.ForEach(val => Console.WriteLine(val));
    }

    public static IEnumerable<Product> GetSampleProducts() => new List<Product>()
    {
        new Product {Id = 1, Name = "Lenovo Thinkpad", Category = "Computer/Laptop", Price = 11000,  CurrentlyInStock = true},
        new Product {Id = 2, Name = "Razor Blackadder", Category = "Computer/Accesories", Price = 900, CurrentlyInStock = true},
        new Product {Id = 3, Name = "ASUS Motherboard", Category = "Computer/Desktop", Price = 3200, CurrentlyInStock = true},
        new Product {Id = 4, Name = "Dell Server", Category = "Server/Terminal", Price = 51000, CurrentlyInStock = false}
    };
}