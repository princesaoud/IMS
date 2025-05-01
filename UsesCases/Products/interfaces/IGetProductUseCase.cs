using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IGetProductUseCase
{
    Task<Product> Execute(int id);
}