using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerService customerService;

        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;

        }
        


        // GET: CustomerController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Customer Details(int id)
        {
            var data = customerService.GetCustomerById(id);
            return data;
        }

        // GET: CustomerController/Create

        // POST: CustomerController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]
        
        public IActionResult Create(Customer model)
        {
            try
            {
                customerService.AddCustomer(model);
                return Ok(200);
            }
            catch (Exception ex)
            {
                return Ok(400);
            }
        }


        // POST: CustomerController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditCustomer")]
        public void Edit(int id, Customer model)
        {
            try
            {
                customerService.UpdateCustomer(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CustomerController/Delete/5
        [HttpGet]
        [Route("CustomerDelete")]
        public string Delete(int id)
        {
            customerService.DeleteCustomer(id);

            return "Deleted Record Successfully";
        }


    }
}
