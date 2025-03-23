namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IAddInventoryUseCase
    {
        public Task ExecuteAsync(Inventory inventory);
    }
}