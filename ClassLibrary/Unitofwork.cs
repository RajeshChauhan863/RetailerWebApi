using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitofWork
{
    public class Unitofwork : IUnitofWork
    {
        private readonly PosRetailContext _context;
        private ICustomerRepository<Customer> _customerRepository;
        private IinventoryRepository<Inventory> _inventoryRepository;
        private IProductRepository<Product> _productRepository;
        private ICategoryRepository<Category> _categoryRepository;
        private IPurchaseOrderRepository<PurchaseOrder> _purchaseOrderRepository;
        private IPurchaseOrderDetailRepository<PurchaseOrderDetail> _purchaseOrderDetailRepository;
        private ISalesOrderRepository<SalesOrder> _salesOrderRepository;
        private ISalesOrderDetailRepository<SalesOrderDetail> _salesOrderDetailRepository;
        private ISupplierRepository<Supplier> _supplierRepository;

        private IWareHouseRepository<WareHouse> _wareHouseRepository;

        public Unitofwork(PosRetailContext context)
        {
            _context = context;
        }

        public ICustomerRepository<Customer> CustomerRepository
        {
            get
            {
                return _customerRepository ??= new CustomerRepository(_context);
            }
        }


        public IinventoryRepository<Inventory> InventoryRepository
        {
            get
            {
                return _inventoryRepository ??= new InventoryRepository(_context);
            }
        }

        public IProductRepository<Product> ProductRepository
        {
            get
            {
                return _productRepository ??= new ProductRepository(_context); 
            }
        }

        public ICategoryRepository<Category> CategoryRepository
        {
            get
            {
                return _categoryRepository ??= new CategoryRepository(_context);
            }
        }

        public IPurchaseOrderRepository<PurchaseOrder> PurchaseOrderRepository
        {
            get
            {
                return _purchaseOrderRepository ??= new PurchaseOrderRepository(_context);
            }
        }

        public IPurchaseOrderDetailRepository<PurchaseOrderDetail> PurchaseOrderDetailRepository
        {
            get
            {
                return _purchaseOrderDetailRepository ??= new PurchaseOrderDetailRepository(_context);
            }
        }

        public ISalesOrderRepository<SalesOrder> SalesOrderRepository
        {
            get
            {
                return _salesOrderRepository ??= new SalesOrderRepository(_context);
            }
        }

        public ISalesOrderDetailRepository<SalesOrderDetail> SalesOrderDetailRepository
        {
            get
            {
                return _salesOrderDetailRepository ??= new SalesOrderDetailRepository(_context);
            }
        }
        public ISupplierRepository<Supplier> SupplierRepository
        {
            get
            {
                return _supplierRepository ??= new SupplierRepository(_context);
            }
        }
        public IWareHouseRepository<WareHouse> WareHouseRepository
        {
            get
            {
                return _wareHouseRepository ??= new WareHouseRepository(_context);
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
