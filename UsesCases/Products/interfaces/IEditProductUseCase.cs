using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IEditProductUseCase
{
    void Execute(Product product);
}
