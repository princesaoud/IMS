using System;
using CoreBusiness;

namespace UsesCases.Inventories.interfaces;

public interface IEditInventoryUseCase
{
    void Execute(Inventory inventory);
}

