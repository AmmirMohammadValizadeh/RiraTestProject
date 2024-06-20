using RiraTestProject.Entities;
using RiraTestProject.Services;

IProductsService service = new ProductsService(); // We will use DI later ...

var allCategory1Products = service.GetByCategory(ProductCategory.Category1);
var maxPrice = service.GetMostExpensive();
var sumOfPrices = service.GetPriceSum();
var averagePRice = service.GetPriceAverage();
var groupedByCategoryProducts = service.GetGroupedByCategory();

Console.ReadKey();