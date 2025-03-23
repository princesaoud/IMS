using CoreBusiness;
using UsesCases.Inventories.Interfaces;


public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
{
    private IInventoryRepository _inventoryRepository;

    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository)
    {
        _inventoryRepository = inventoryRepository;
    }

    // public List<Inventory> Execute(string name)
    // {
    //     return _inventoryRepository.GetByName(name);
    // }

    public async Task<List<Inventory>> Execute(string name)
    {
        return await _inventoryRepository.GetByName(name);
    }


}