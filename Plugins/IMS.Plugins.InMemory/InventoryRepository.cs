

using CoreBusiness;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        List<Inventory> _inventories;
        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory() { InventoryId = 1,  InventoryName = "Bike Seat", Quantity = 10 , Price = 2},
                new Inventory() {  InventoryId = 2,  InventoryName = "Bike part", Quantity = 10, Price = 10},
                new Inventory() { InventoryId = 3,  InventoryName = "Bike Wheels", Quantity = 20, Price = 18},
                new Inventory() { InventoryId = 4,  InventoryName = "Bike Pedels", Quantity = 20, Price = 4},
            };
        }
        public List<Inventory> GetByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _inventories;
            }
            return _inventories.Where(i => i.InventoryName.Contains(name)).ToList();
        }
    }

}



