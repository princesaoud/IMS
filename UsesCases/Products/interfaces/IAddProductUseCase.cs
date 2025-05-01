using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IAddProductUseCase
{
    void Execute(Product product);
}