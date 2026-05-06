using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SupplierRepository : ISupplierRepository<Supplier>
    {
        private readonly PosRetailContext _context;

        public SupplierRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void Add(Supplier entity)
        {
            _context.Suppliers.Add(entity);
        }

        public void Update(Supplier entity)
        {
            _context.Suppliers.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Suppliers.Find(id);
            if (entity != null)
            {
                _context.Suppliers.Remove(entity);
            }
        }
    }
}
