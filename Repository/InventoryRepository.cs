using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InventoryRepository : IinventoryRepository<Inventory>
    {
        private readonly PosRetailContext _context;

        public InventoryRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<Inventory> GetAll()
        {
            return _context.Inventories.ToList();
        }

        public Inventory GetById(int id)
        {
            return _context.Inventories.Find(id);
        }

        public void Add(Inventory entity)
        {
            _context.Inventories.Add(entity);
        }

        public void Update(Inventory entity)
        {
            _context.Inventories.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Inventories.Find(id);
            if (entity != null)
            {
                _context.Inventories.Remove(entity);
            }
        }

    }
}
