using CoreBusiness;

public interface IInventoryRepository
{
    public Task AddInventoryAsync(Inventory inventory);
    public List<Inventory> GetByName(string name);
    public Inventory Get(int id);
    public Task Update(Inventory inventory);
}