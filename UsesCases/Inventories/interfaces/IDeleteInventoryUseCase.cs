using System;

namespace UsesCases.Inventories.interfaces;

public interface IDeleteInventoryUseCase
{
    Task Execute(int id);
}
