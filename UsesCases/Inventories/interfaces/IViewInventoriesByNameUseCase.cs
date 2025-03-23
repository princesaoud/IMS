using CoreBusiness;

namespace UsesCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        public Task<List<Inventory>> Execute(string name);

    }
}