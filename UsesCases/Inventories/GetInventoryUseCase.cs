
using System;
using CoreBusiness;
using UsesCases.Inventories.interfaces;

namespace UsesCases.Inventories;



public class GetInventoryUseCase : IGetInventoryUseCase
{
    IInventoryRepository inventoryRepository;

    public GetInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }

    public async Task<Inventory> Execute(int inventoryId)
    {
        var inventory = await inventoryRepository.Get(inventoryId);

        if (inventory == null)
        {
            throw new Exception("Inventory not found");
        }

        return inventory;
    }
}
