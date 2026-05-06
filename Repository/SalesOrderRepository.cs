using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SalesOrderRepository : ISalesOrderRepository<SalesOrder>
    {
        private readonly PosRetailContext _context;

        public SalesOrderRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesOrder> GetAll()
        {
            return _context.SalesOrders.ToList();
        }

        public SalesOrder GetById(int id)
        {
            return _context.SalesOrders.Find(id);
        }

        public void Add(SalesOrder entity)
        {
            _context.SalesOrders.Add(entity);
        }

        public void Update(SalesOrder entity)
        {
            _context.SalesOrders.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.SalesOrders.Find(id);
            if (entity != null)
            {
                _context.SalesOrders.Remove(entity);
            }
        }
    }
}
