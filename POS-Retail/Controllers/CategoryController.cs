using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService customerService;

        public CategoryController(ICategoryService _customerService)
        {
            customerService = _customerService;

        }



        // GET: CategoryController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Category Details(int id)
        {
            var data = customerService.GetCategoryById(id);
            return data;
        }

        // GET: CategoryController/Create

        // POST: CategoryController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Category model)
        {
            try
            {
                customerService.AddCategory(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: CategoryController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditCategory")]
        public void Edit(int id, Category model)
        {
            try
            {
                customerService.UpdateCategory(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CateogryController/Delete/5
        [HttpGet]
        [Route("CategoryDelete")]
        public string Delete(int id)
        {
            customerService.DeleteCategory(id);

            return "Deleted Record Successfully";
        }


    }
}

