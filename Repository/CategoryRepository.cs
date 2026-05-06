using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository<Category>
    {
        private readonly PosRetailContext _context;

        public CategoryRepository(PosRetailContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
        }

        public void Update(Category entity)
        {
            _context.Categories.Update(entity);
        }

        public void Delete(int id)
        {
            var entity = _context.Categories.Find(id);
            if (entity != null)
            {
                _context.Categories.Remove(entity);
            }
        }
    }
}
