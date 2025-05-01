using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IEditProductUseCase
{
    Task Execute(Product product);
}
