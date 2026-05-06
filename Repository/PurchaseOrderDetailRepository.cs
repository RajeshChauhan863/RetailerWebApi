using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PurchaseOrderDetailRepository : IPurchaseOrderDetailRepository<PurchaseOrderDetail>
    {
        private readonly PosRetailContext _context;

        public PurchaseOrderDetailRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<PurchaseOrderDetail> GetAll()
        {
            return _context.PurchaseOrderDetails.ToList();
        }

        public PurchaseOrderDetail GetById(int id)
        {
            return _context.PurchaseOrderDetails.Find(id);
        }

        public void Add(PurchaseOrderDetail entity)
        {
            _context.PurchaseOrderDetails.Add(entity);
        }

        public void Update(PurchaseOrderDetail entity)
        {
            _context.PurchaseOrderDetails.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.PurchaseOrderDetails.Find(id);
            if (entity != null)
            {
                _context.PurchaseOrderDetails.Remove(entity);
            }
        }
    }
}

