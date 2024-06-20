using RiraTestProject.Entities;

namespace RiraTestProject.Services;

public interface IProductsService
{
    List<Product> GetAllProducts();
    List<Product> GetByCategory(ProductCategory category);
    Product? GetMostExpensive();
    decimal GetPriceSum();
    IEnumerable<IGrouping<ProductCategory, Product>> GetGroupedByCategory();
    decimal GetPriceAverage();
}