using Sliit.MTIT.Supplier.Data;

namespace Sliit.MTIT.Supplier.Servces
{
    public class SupplierService : ISupplierService
    {
        public Models.Supplier? AddSupplier(Models.Supplier supplier)
        {
            SupplierMockDataService.supplieres.Add(supplier);
            return supplier;
        }

        public Models.Supplier? GetSupplier(int id)
        {
            return SupplierMockDataService.supplieres.FirstOrDefault(x => x.Id == id);
        }

        public List<Models.Supplier> GetSuppliers()
        {
            return SupplierMockDataService.supplieres;
        }
    }
}
