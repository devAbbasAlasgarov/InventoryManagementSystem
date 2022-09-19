

namespace IMS.Plugins.EFCore
{
    public class InventoryRepository : IInventoryRepository
    {
        private IMSContext db;

        public InventoryRepository(IMSContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByName(string name)
        {
            return await this.db.Inventories.Where(x => x.InventoryName.Contains(name) ||
                                                    string.IsNullOrWhiteSpace(name)).ToListAsync();
        }

    }

    public class Inventory
    {
    }

    public interface IInventoryRepository
    {
    }

    
}
