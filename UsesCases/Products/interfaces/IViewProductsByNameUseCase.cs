using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IViewProductsByNameUseCase
{
    Task<List<Product>> Execute(string name);
}
