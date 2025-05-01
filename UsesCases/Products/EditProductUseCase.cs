using System;
using CoreBusiness;
using UsesCases.PluginInterfaces;
using UsesCases.Products.interfaces;

namespace UsesCases.Products;


public class EditProductUseCase : IEditProductUseCase
{

    private readonly IProductRepository _productRepository;

    public EditProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task Execute(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        _productRepository.UpdateProduct(product);
        return Task.CompletedTask;
    }
}
