using System;
using CoreBusiness;
using UsesCases.Inventories.interfaces;

namespace UsesCases.Inventories;


public class EditInventoryUseCase : IEditInventoryUseCase
{
    IInventoryRepository inventoryRepository;
    public EditInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        this.inventoryRepository = inventoryRepository;
    }


    public async Task Execute(Inventory inventory)
    {

        var inv = await inventoryRepository.Get(inventory.InventoryId);

        if (inv == null)
        {
            throw new Exception("Inventory not found");
        }
        inv.InventoryName = inventory.InventoryName;
        inv.Quantity = inventory.Quantity;
        inv.Price = inventory.Price;
        await inventoryRepository.Update(inventory);
    }
}
