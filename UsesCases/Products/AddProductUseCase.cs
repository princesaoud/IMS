using System;
using CoreBusiness;
using UsesCases.PluginInterfaces;
using UsesCases.Products.interfaces;

namespace UsesCases.Products;
public class AddProductUseCase : IAddProductUseCase
{
    private readonly IProductRepository _productRepository;

    public AddProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void Execute(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product), "Product cannot be null.");
        if (string.IsNullOrWhiteSpace(product.Name)) throw new ArgumentException("Product name cannot be empty.", nameof(product.Name));
        if (product.Price <= 0) throw new ArgumentOutOfRangeException(nameof(product.Price), "Price must be greater than zero.");

        _productRepository.AddProduct(product);
    }
}
