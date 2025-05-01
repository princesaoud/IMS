using System;
using CoreBusiness;
using UsesCases.PluginInterfaces;
using UsesCases.Products.interfaces;

namespace UsesCases.Products;



public class GetProductUseCase : IGetProductUseCase
{
    private readonly IProductRepository _productRepository;

    public GetProductUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<Product> Execute(int id)
    {
        var data = _productRepository.GetProductById(id);
        return Task.FromResult(data);
    }

}
