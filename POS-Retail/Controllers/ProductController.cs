using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class ProductController : ControllerBase
    {
        IProductService productService;

        public ProductController(IProductService _productService)
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

        public IActionResult Create(Product model)
        {
            try
            {
                productService.AddProduct(model);
                return Ok(200);
            }
            catch (Exception ex)
            {
                return Ok(400);
            }
        }


        // POST: ProductController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditProduct")]
        public IActionResult Edit(int id, Product model)
        {
            try
            {
                productService.UpdateProduct(model);
                return Ok(200);
            }
            catch
            {
                return Ok(400);
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
