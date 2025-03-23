using System;
using CoreBusiness;

namespace UsesCases.Inventories.interfaces;

public interface IGetInventoryUseCase
{
    Task<Inventory> Execute(int inventoryId);
}