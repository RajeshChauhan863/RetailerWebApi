using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SalesOrderDetailRepository : ISalesOrderDetailRepository<SalesOrderDetail>
    {
        private readonly PosRetailContext _context;

        public SalesOrderDetailRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesOrderDetail> GetAll()
        {
            return _context.SalesOrderDetails.ToList();
        }

        public SalesOrderDetail GetById(int id)
        {
            return _context.SalesOrderDetails.Find(id);
        }

        public void Add(SalesOrderDetail entity)
        {
            _context.SalesOrderDetails.Add(entity);
        }

        public void Update(SalesOrderDetail entity)
        {
            _context.SalesOrderDetails.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.SalesOrderDetails.Find(id);
            if (entity != null)
            {
                _context.SalesOrderDetails.Remove(entity);
            }
        }
    }
}
