using RiraTestProject.Entities;

namespace RiraTestProject.Services;

public interface IProductsService
{
    IEnumerable<Product> GetAllProducts();
    IEnumerable<Product> GetByCategory(ProductCategory category);
    Product? GetMostExpensive();
    decimal GetPriceSum();
    IEnumerable<IGrouping<ProductCategory, Product>> GetGroupedByCategory();
    decimal GetPriceAverage();
}