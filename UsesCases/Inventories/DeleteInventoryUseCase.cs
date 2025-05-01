using System;
using UsesCases.Inventories.interfaces;

namespace UsesCases.Inventories;



public class DeleteInventoryUseCase : IDeleteInventoryUseCase
{

    private readonly IInventoryRepository _inventoryRepository;

    public DeleteInventoryUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    public async Task Execute(int id)
    {
        await _inventoryRepository.Delete(id);
    }
}
