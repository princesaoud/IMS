using System;
using CoreBusiness;

namespace UsesCases.PluginInterfaces;

public interface IProductRepository
{
    void AddProduct(Product product);
    Task DeleteProductAsync(int id);
    Product GetProductById(int id);
    List<Product> GetProductsByName(string name);
    void UpdateProduct(Product product);
}
