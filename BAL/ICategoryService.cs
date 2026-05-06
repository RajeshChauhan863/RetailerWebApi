using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void AddCategory(Category product);
        void UpdateCategory(Category product);
        void DeleteCategory(int id);

    }
}
