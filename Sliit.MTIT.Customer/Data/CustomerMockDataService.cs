namespace Sliit.MTIT.Customer.Data
{
    public class CustomerMockDataService
    {
        public static List<Models.Customer> customers = new List<Models.Customer>()
        {
            new Models.Customer { Id = 1, Name = "John", Address = "123 Main St", Age = 20 },
            new Models.Customer { Id = 2, Name = "Mary", Address = "456 Second Ave", Age = 22 },
            new Models.Customer { Id = 3, Name = "Tom", Address = "789 Third St", Age = 21 },
            new Models.Customer { Id = 4, Name = "Kate", Address = "321 Fourth Ave", Age = 23 },
            new Models.Customer { Id = 5, Name = "Mike", Address = "654 Fifth St", Age =19 }
        };
    }
}
