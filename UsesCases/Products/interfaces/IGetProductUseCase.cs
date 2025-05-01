using System;
using CoreBusiness;

namespace UsesCases.Products.interfaces;

public interface IGetProductUseCase
{
    Product Execute(int id);
}