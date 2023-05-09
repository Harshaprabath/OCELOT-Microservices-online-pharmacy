namespace Sliit.MTIT.Inventory.Services
{
    public interface IInventoryService
    {
        List<Models.Inventory> GetInventories();

        Models.Inventory? GetInventory(int id);

        Models.Inventory? AddInventory(Models.Inventory inventory);

        Models.Inventory? UpdateInventory(Models.Inventory inventory);

        bool? DeleteInventory(int id);
    }
}
