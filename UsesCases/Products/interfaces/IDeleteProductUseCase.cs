using System;

namespace UsesCases.Products.interfaces;

public interface IDeleteProductUseCase
{
    void Execute(int id);
}