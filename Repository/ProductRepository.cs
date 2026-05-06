using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository<Product>
    {
        private readonly PosRetailContext _context;

        public ProductRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void Update(Product entity)
        {
            _context.Products.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Products.Find(id);
            if (entity != null)
            {
                _context.Products.Remove(entity);
            }
        }
    }
}
