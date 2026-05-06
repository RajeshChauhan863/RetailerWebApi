using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository<PurchaseOrder>
    {
        private readonly PosRetailContext _context;

        public PurchaseOrderRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<PurchaseOrder> GetAll()
        {
            return _context.PurchaseOrders.ToList();
        }

        public PurchaseOrder GetById(int id)
        {
            return _context.PurchaseOrders.Find(id);
        }

        public void Add(PurchaseOrder entity)
        {
            _context.PurchaseOrders.Add(entity);
        }

        public void Update(PurchaseOrder entity)
        {
            _context.PurchaseOrders.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.PurchaseOrders.Find(id);
            if (entity != null)
            {
                _context.PurchaseOrders.Remove(entity);
            }
        }
    }
}

