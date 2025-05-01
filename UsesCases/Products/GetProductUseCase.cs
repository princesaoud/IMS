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

    public Product Execute(int id)
    {
        return _productRepository.GetProductById(id);
    }

}
