

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

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(i => i.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                // throw new Exception("Inventory already exists");
                return Task.CompletedTask;
            }
            inventory.InventoryId = _inventories.Max(i => i.InventoryId) + 1;
            _inventories.Add(inventory);
            return Task.CompletedTask;

        }

        public List<Inventory> GetByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _inventories;
            }
            return _inventories.Where(i => i.InventoryName.Contains(name)).ToList();
        }


        public Inventory Get(int id)
        {
            var data = _inventories.FirstOrDefault(i => i.InventoryId == id);
            if (data == null)
            {
                throw new Exception("Inventory not found");
            }
            return data;

        }



        public async Task Update(Inventory inventory)
        {
            if (_inventories.Any(i =>
            i.InventoryId != inventory.InventoryId
            && i.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase)))
            {
                // throw new Exception("Inventory already exists");
                await Task.CompletedTask;
            }

            var data = _inventories.FirstOrDefault(i => i.InventoryId == inventory.InventoryId);
            if (data == null)
            {
                throw new Exception("Inventory not found");
            }
            data.InventoryName = inventory.InventoryName;
            data.Quantity = inventory.Quantity;
            data.Price = inventory.Price;
            await Task.CompletedTask;
        }
    }

}



