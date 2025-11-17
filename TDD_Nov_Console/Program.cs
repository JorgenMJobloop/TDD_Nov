using TDD_Nov.Models;
using TDD_Nov.Services;
using TDD_Nov.Utilities;

namespace TDD_Nov;

class Program
{
    static void Main(string[] args)
    {
        // Product product = new Product();
        // product.Name = "Xbox"; // initalizing a object from a class
        // Console.Beep(); // Console is a single-purpose static class, so we cannot initalize objects to it, or inherit it in other classes.

        // List<string> values = ["Hello", "from", "IEnumerable", "and", "regular", "for", "each", "loop"];
        // DataSeeder.LoopThroughData(values);

        // Initalze a new ProductService object, and use the static DataSeeder class to pass it values.
        ProductService service = new ProductService(DataSeeder.GetSampleProducts());

        Console.WriteLine("Products available");
        foreach (var p in service.GetAvailableProducts())
        {
            Console.WriteLine(p);
        }
    }
}