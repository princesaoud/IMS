using System;
using UsesCases.PluginInterfaces;
using UsesCases.Products.interfaces;

namespace UsesCases.Products;



public class DeleteProductUseCase : IDeleteProductUseCase
{

    private readonly IProductRepository _productRepository;

    public DeleteProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public void Execute(int id)
    {
        if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "Id must be greater than zero.");
        var product = _productRepository.GetProductById(id);
        if (product == null) throw new ArgumentNullException(nameof(product), "Product not found.");
        _productRepository.DeleteProduct(product);
    }
}
