using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderDetailController : ControllerBase
    {
        ISalesOrderDetailService saleOrderDetailService;

        public SalesOrderDetailController(ISalesOrderDetailService _saleOrderDetailService)
        {
            saleOrderDetailService = _saleOrderDetailService;

        }



        // GET: SalesOrderController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public SalesOrderDetail Details(int id)
        {
            var data = saleOrderDetailService.GetSalesOrderDetailById(id);
            return data;
        }

        // GET: SalesOrerDetailController/Create

        // POST: SalesOrerDetailController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(SalesOrderDetail model)
        {
            try
            {
                saleOrderDetailService.AddSalesOrderDetail(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: SalesOrderDetailController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditSalesOrder")]
        public void Edit(int id, SalesOrderDetail model)
        {
            try
            {
                saleOrderDetailService.UpdateSalesOrderDetail(model);
            }
            catch
            {
                return;
            }
        }

        // GET: SalesOrderDetailController/Delete/5
        [HttpGet]
        [Route("SalesOrderDetailDelete")]
        public string Delete(int id)
        {
            saleOrderDetailService.DeleteSalesOrderDetail(id);

            return "Deleted Record Successfully";
        }
    }
}
