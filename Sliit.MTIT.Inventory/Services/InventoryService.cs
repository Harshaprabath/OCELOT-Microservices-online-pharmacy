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

        public bool? DeleteInventory(int id)
        {

            Models.Inventory selectedInventory = InventoryMockDataService.inventories.FirstOrDefault(x => x.Id == id);
            if (selectedInventory != null)
            {
                InventoryMockDataService.inventories.Remove(selectedInventory);
                return true;
            }
            return false;
        }

        public List<Models.Inventory> GetInventories()
        {
            return InventoryMockDataService.inventories;
        }

        public Models.Inventory? GetInventory(int id)
        {
            return InventoryMockDataService.inventories.FirstOrDefault(x => x.Id == id);
        }

        public Models.Inventory? UpdateInventory(Models.Inventory inventory)
        {
            Models.Inventory selectedInventory = InventoryMockDataService.inventories.FirstOrDefault(x => x.Id == inventory.Id);
            if (selectedInventory != null)
            {
                
                selectedInventory.Code = inventory.Code;
                selectedInventory.Name = inventory.Name;
                return selectedInventory;
            }
            return selectedInventory;
        }
    }
}
