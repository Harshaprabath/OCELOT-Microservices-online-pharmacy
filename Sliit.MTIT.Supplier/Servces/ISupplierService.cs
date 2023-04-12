namespace Sliit.MTIT.Supplier.Servces
{
    public interface ISupplierService
    {
        List<Models.Supplier> GetSuppliers();

        Models.Supplier? GetSupplier(int id);

        Models.Supplier? AddSupplier(Models.Supplier supplier);
    }
}
