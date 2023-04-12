namespace Sliit.MTIT.Supplier.Data
{
    public class SupplierMockDataService
    {
        public static List<Models.Supplier> supplieres = new List<Models.Supplier>()
        {
            new Models.Supplier { Id = 1, Name = "John", Address = "123 Main St", Age = 20 },
            new Models.Supplier { Id = 2, Name = "Mary", Address = "456 Second Ave", Age = 22 },
            new Models.Supplier { Id = 3, Name = "Tom", Address = "789 Third St", Age = 21 },
            new Models.Supplier { Id = 4, Name = "Kate", Address = "321 Fourth Ave", Age = 23 },
            new Models.Supplier { Id = 5, Name = "Mike", Address = "654 Fifth St", Age =19 }
        };
    }
}
