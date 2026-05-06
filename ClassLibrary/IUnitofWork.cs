using DAL.Models;
using Repository;

namespace UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        ICustomerRepository<Customer> CustomerRepository { get; }
        IinventoryRepository<Inventory> InventoryRepository { get; }
        IProductRepository<Product> ProductRepository { get; }
        ICategoryRepository<Category> CategoryRepository { get; }
        IPurchaseOrderRepository<PurchaseOrder> PurchaseOrderRepository { get; }
        IPurchaseOrderDetailRepository<PurchaseOrderDetail> PurchaseOrderDetailRepository { get; }

        ISalesOrderRepository<SalesOrder> SalesOrderRepository { get; }

        ISalesOrderDetailRepository<SalesOrderDetail> SalesOrderDetailRepository { get; }

        ISupplierRepository<Supplier> SupplierRepository { get; }

        IWareHouseRepository<WareHouse> WareHouseRepository { get; }


        void SaveChanges();
    }
}
