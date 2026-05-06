using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProuductController : ControllerBase
    {
        IProductService productService;

        public ProuductController(IProductService _productService)
        {
            productService = _productService;

        }

        // GET: ProductController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Product Details(int id)
        {
            var data = productService.GetProductById(id);
            return data;
        }

        
        // POST: ProductController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Product model)
        {
            try
            {
                productService.AddProduct(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: ProductController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditProduct")]
        public void Edit(int id, Product model)
        {
            try
            {
                productService.UpdateProduct(model);
            }
            catch
            {
                return;
            }
        }

        // GET: ProductController/Delete/5
        [HttpGet]
        [Route("ProductDelete")]
        public string Delete(int id)
        {
            productService.DeleteProduct(id);

            return "Deleted Record Successfully";
        }

    }
}
