namespace RiraTestProject.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ProductCategory CategoryId { get; set; } //Category is not a good name for integers
    public decimal Price { get; set; }
}
