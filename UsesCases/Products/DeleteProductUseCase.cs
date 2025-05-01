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

    public async Task ExecuteAsync(int id)
    {
        await _productRepository.DeleteProductAsync(id);
    }

}
