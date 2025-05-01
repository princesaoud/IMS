using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IAddProductUseCase
{
    Task Execute(Product product);
}