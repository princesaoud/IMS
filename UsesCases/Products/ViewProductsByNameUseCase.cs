using System;
using CoreBusiness;
using UsesCases.PluginInterfaces;
using UsesCases.Products.interfaces;

namespace UsesCases.Products;



public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
{

    private readonly IProductRepository _productRepository;

    public ViewProductsByNameUseCase(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public List<Product> Execute(string name)
    {
        return _productRepository.GetProductsByName(name);
    }
}
