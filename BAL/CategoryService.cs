using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork _unitOfWork;

        public CategoryService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Category GetCategoryById(int id)
        {
            return _unitOfWork.CategoryRepository.GetById(id);
        }




        public void AddCategory(Category category)
        {
            _unitOfWork.CategoryRepository.Add(category);
            _unitOfWork.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _unitOfWork.CategoryRepository.Update(category);
            _unitOfWork.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            _unitOfWork.CategoryRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _unitOfWork.CategoryRepository.GetAll();
        }

    }
}
