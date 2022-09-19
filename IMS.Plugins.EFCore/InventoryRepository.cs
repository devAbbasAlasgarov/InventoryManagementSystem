using IMS.CoreBusiness;
using IMS.UseCases.PlugInterfaces;

namespace IMS.Plugins.EFCore;
public class InventoryRepository : IInventoryRepository
{
    public Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
    {
        throw new NotImplementedException();
    }

}

