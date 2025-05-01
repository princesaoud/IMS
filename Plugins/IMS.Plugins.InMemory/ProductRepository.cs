using System;
using CoreBusiness;
using UsesCases.PluginInterfaces;

namespace IMS.Plugins.InMemory;

public class ProductRepository : IProductRepository
{
    List<Product> _inventories;
    public ProductRepository()
    {
        _inventories = new List<Product>()
            {
                new Product() { ProductId = 1,  Name = "Bike", Quantity = 10 , Price = 20500},
                new Product() {  ProductId = 2,  Name = "Car", Quantity = 10, Price = 10500},
                new Product() { ProductId = 3,  Name = "Bicycle", Quantity = 20, Price = 18000},
                new Product() { ProductId = 4,  Name = "Mercedes GLE", Quantity = 20, Price = 40000},
            };
    }
    public void AddProduct(Product product)
    {
        if (_inventories.Any(i => i.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
        {
            // throw new Exception("Product already exists");
            return;
        }
        product.ProductId = _inventories.Max(i => i.ProductId) + 1;
        _inventories.Add(product);
    }

    public void DeleteProduct(Product product)
    {
        var data = _inventories.FirstOrDefault(i => i.ProductId == product.ProductId);
        if (data == null)
        {
            throw new Exception("Product not found");
        }
        _inventories.Remove(data);
    }

    public Product GetProductById(int id)
    {
        var data = _inventories.FirstOrDefault(i => i.ProductId == id);
        if (data == null)
        {
            throw new Exception("Product not found");
        }
        return data;
    }

    public List<Product> GetProductsByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return _inventories;
        }
        return _inventories
            .Where(i => i.Name != null && i.Name.ToLowerInvariant().Contains(name.ToLowerInvariant()))
            .ToList();
    }

    public void UpdateProduct(Product product)
    {
        var data = _inventories.FirstOrDefault(i => i.ProductId == product.ProductId);
        if (data == null)
        {
            throw new Exception("Product not found");
        }
        data.Name = product.Name;
        data.Price = product.Price;
        data.Quantity = product.Quantity;
        if (_inventories.Any(i =>
            i.ProductId != product.ProductId
            && i.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
        {
            // throw new Exception("Product already exists");
            return;
        }
    }
}
