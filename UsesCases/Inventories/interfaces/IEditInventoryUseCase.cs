using System;
using CoreBusiness;

namespace UsesCases.Inventories.interfaces;

public interface IEditInventoryUseCase
{
    Task Execute(Inventory inventory);
}

