using CoreBusiness;

public interface IInventoryRepository
{
    public Task AddInventoryAsync(Inventory inventory);
    public Task<List<Inventory>> GetByName(string name);
    public Task<Inventory> Get(int id);
    public Task Update(Inventory inventory);
}