namespace TDD_Nov.Models;
/// <summary>
/// A type of "product" class model
/// </summary>
public class Product
{
    /// <summary>
    /// A unique ID (database)
    /// </summary>
    public int Id { get; init; }
    /// <summary>
    /// The name of the product
    /// </summary>
    public string Name { get; set; } = string.Empty;
    /// <summary>
    /// Category / type of product
    /// </summary>
    public string Category { get; set; } = string.Empty;
    /// <summary>
    /// The price of a given product
    /// </summary>
    public double Price { get; set; }
    /// <summary>
    /// If a product is in store (true) otherwise (false)
    /// </summary>
    public bool CurrentlyInStock { get; set; }

    // a overwritten ToString() implementation
    public override string ToString()
    {
        return $"{Name} ({Category}) - {Price:C}";
    }
}