using CoreBusiness;

public interface IInventoryRepository
{
    public Task AddInventoryAsync(Inventory inventory);
    public List<Inventory> GetByName(string name);
}