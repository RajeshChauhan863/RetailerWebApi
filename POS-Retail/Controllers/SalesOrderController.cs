using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderController : ControllerBase
    {
        ISalesOrderService saleOrderService;

        public SalesOrderController(ISalesOrderService _saleOrderService)
        {
            saleOrderService = _saleOrderService;

        }



        // GET: SalesOrderController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public SalesOrder Details(int id)
        {
            var data = saleOrderService.GetSalesOrderById(id);
            return data;
        }

        // GET: CategoryController/Create

        // POST: CategoryController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(SalesOrder model)
        {
            try
            {
                saleOrderService.AddSalesOrder(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: SalesOrderController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditSalesOrder")]
        public void Edit(int id, SalesOrder model)
        {
            try
            {
                saleOrderService.UpdateSalesOrder(model);
            }
            catch
            {
                return;
            }
        }

        // GET: SalesOrderController/Delete/5
        [HttpGet]
        [Route("SalesOrderDelete")]
        public string Delete(int id)
        {
            saleOrderService.DeleteSalesOrder(id);

            return "Deleted Record Successfully";
        }
    }
}
