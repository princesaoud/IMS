using CoreBusiness;

public interface IInventoryRepository
{
    public List<Inventory> GetByName(string name);
}