using System;

namespace UsesCases.Products.interfaces;

public interface IDeleteProductUseCase
{
    Task Execute(int id);
}