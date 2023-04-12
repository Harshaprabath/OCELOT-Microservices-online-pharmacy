namespace Sliit.MTIT.Inventory.Data
{
    public class InventoryMockDataService
    {
        public static List<Models.Inventory> inventories = new List<Models.Inventory>()
        {
            new Models.Inventory { Id = 1, Name = "Penadol", Code = "P100" },
            new Models.Inventory { Id = 2, Name = "Fish Oile", Code = "F10"},
            new Models.Inventory { Id = 3, Name = "Vitamin C", Code = "V789" },
            new Models.Inventory { Id = 4, Name = "Panadeine", Code = "P321" },
            new Models.Inventory { Id = 5, Name = "Vitamin D", Code = "V654"}
        };
    }
}
