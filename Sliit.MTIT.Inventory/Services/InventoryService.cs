using Sliit.MTIT.Inventory.Data;

namespace Sliit.MTIT.Inventory.Services
{
    public class InventoryService : IInventoryService
    {
        public Models.Inventory? AddInventory(Models.Inventory inventory)
        {
            InventoryMockDataService.inventories.Add(inventory);
            return inventory;
        }

        public List<Models.Inventory> GetInventories()
        {
            return InventoryMockDataService.inventories;
        }

        public Models.Inventory? GetInventory(int id)
        {
            return InventoryMockDataService.inventories.FirstOrDefault(x => x.Id == id);
        }
    }
}
