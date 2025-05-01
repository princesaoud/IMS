using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IViewProductsByNameUseCase
{
    List<Product> Execute(string name);
}
