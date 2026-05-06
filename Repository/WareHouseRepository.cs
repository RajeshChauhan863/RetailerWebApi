using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class WareHouseRepository : IWareHouseRepository<WareHouse>
    {
        private readonly PosRetailContext _context;

        public WareHouseRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<WareHouse> GetAll()
        {
            return _context.WareHouses.ToList();
        }

        public WareHouse GetById(int id)
        {
            return _context.WareHouses.Find(id);
        }

        public void Add(WareHouse entity)
        {
            _context.WareHouses.Add(entity);
        }

        public void Update(WareHouse entity)
        {
            _context.WareHouses.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.WareHouses.Find(id);
            if (entity != null)
            {
                _context.WareHouses.Remove(entity);
            }
        }
    }
}
