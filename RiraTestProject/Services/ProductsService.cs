using RiraTestProject.Entities;

namespace RiraTestProject.Services;

public class ProductsService : IProductsService
{
    public IEnumerable<Product> GetAllProducts()
    {
        return new List<Product>()
        {
            new() { Id = 1, Name = "Product A", CategoryId = ProductCategory.Category1, Price = 100 },
            new() { Id = 2, Name = "Product B", CategoryId = ProductCategory.Category1, Price = 150 },
            new() { Id = 3, Name = "Product C", CategoryId = ProductCategory.Category2, Price = 120 },
            new() { Id = 4, Name = "Product D", CategoryId = ProductCategory.Category3, Price = 200 },
            new() { Id = 5, Name = "Product E", CategoryId = ProductCategory.Category1, Price = 80 }
        };
    }

    public IEnumerable<Product> GetByCategory(ProductCategory category) => GetAllProducts().Where(p => p.CategoryId == category);

    public Product? GetMostExpensive() => GetAllProducts().MaxBy(c => c.Price); //Previous verson OrderBy-Top1

    public decimal GetPriceSum() => GetAllProducts().Sum(c => c.Price);

    public IEnumerable<IGrouping<ProductCategory, Product>> GetGroupedByCategory() => GetAllProducts().GroupBy(c => c.CategoryId);

    public decimal GetPriceAverage() => GetAllProducts().Average(c => c.Price);
}
