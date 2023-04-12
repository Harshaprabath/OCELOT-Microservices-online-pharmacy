namespace Sliit.MTIT.Customer.Services
{
    public interface ICustomerService
    {
        List<Models.Customer> GetCustomers();

        Models.Customer? GetCustomer(int id);

        Models.Customer? AddCustomer(Models.Customer student);

        Models.Customer? UpdateCustomer(Models.Customer student);

        bool? DeleteCustomer(int id);
    }
}
