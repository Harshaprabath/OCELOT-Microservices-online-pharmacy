using Sliit.MTIT.Supplier.Data;

namespace Sliit.MTIT.Supplier.Servces
{
    public class SupplierService : ISupplierService
    {
       
        public Models.Supplier? GetSupplier(int id)
        {
            return SupplierMockDataService.supplieres.FirstOrDefault(x => x.Id == id);
        }

        public List<Models.Supplier> GetSuppliers()
        {
            return SupplierMockDataService.supplieres;
        }
        public Models.Supplier? AddSupplier(Models.Supplier supplier)
        {
            SupplierMockDataService.supplieres.Add(supplier);
            return supplier;
        }

        public bool? DeleteSupplier(int id)
        {

            Models.Supplier selectedSupplier = SupplierMockDataService.supplieres.FirstOrDefault(x => x.Id == id);
            if (selectedSupplier != null)
            {
                SupplierMockDataService.supplieres.Remove(selectedSupplier);
                return true;
            }
            return false;
        }

        public Models.Supplier? UpdateSupplier(Models.Supplier supplier)
        {
            Models.Supplier selectedSupplier = SupplierMockDataService.supplieres.FirstOrDefault(x => x.Id == supplier.Id);
            if (selectedSupplier != null)
            {
                selectedSupplier.Address = supplier.Address;
                selectedSupplier.Age = supplier.Age;
                selectedSupplier.Name = supplier.Name;
                return selectedSupplier;
            }
            return selectedSupplier;
        }
    }
}
