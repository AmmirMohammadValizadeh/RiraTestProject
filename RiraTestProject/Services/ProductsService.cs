using RiraTestProject.Entities;

namespace RiraTestProject.Services;

public class ProductsService : IProductsService
{
    public List<Product> GetAllProducts()
    {
        return new()
        {
            new Product { Id = 1, Name = "Product A", CategoryId = ProductCategory.Category1, Price = 100 },
            new Product { Id = 2, Name = "Product B", CategoryId = ProductCategory.Category1, Price = 150 },
            new Product { Id = 3, Name = "Product C", CategoryId = ProductCategory.Category2, Price = 120 },
            new Product { Id = 4, Name = "Product D", CategoryId = ProductCategory.Category3, Price = 200 },
            new Product { Id = 5, Name = "Product E", CategoryId = ProductCategory.Category1, Price = 80 }
        };
    }

    public List<Product> GetByCategory(ProductCategory category) => GetAllProducts().Where(p => p.CategoryId == category).ToList();

    public Product? GetMostExpensive() => GetAllProducts().MaxBy(c => c.Price);

    public decimal GetPriceSum() => GetAllProducts().Sum(c => c.Price);

    public IEnumerable<IGrouping<ProductCategory, Product>> GetGroupedByCategory() => GetAllProducts().GroupBy(c => c.CategoryId);

    public decimal GetPriceAverage() => GetAllProducts().Average(c => c.Price);
}
