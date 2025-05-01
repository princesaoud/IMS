using System;

namespace UsesCases.Products.interfaces;

public interface IDeleteProductUseCase
{
    Task ExecuteAsync(int id);

}