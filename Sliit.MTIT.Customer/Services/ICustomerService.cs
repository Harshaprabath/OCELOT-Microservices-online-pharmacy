namespace Sliit.MTIT.Customer.Services
{
    public interface ICustomerService
    {
        List<Models.Customer> GetCustomers();

        Models.Customer? GetCustomer(int id);

        Models.Customer? AddCustomer(Models.Customer customer);

        Models.Customer? UpdateCustomer(Models.Customer customer);

        bool? DeleteCustomer(int id);
    }
}
