using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        IPurchaseOrderService purchaseOrderService;

        public PurchaseOrderController(IPurchaseOrderService _purchaseOrderSrvice)
        {
            purchaseOrderService = _purchaseOrderSrvice;

        }



        // GET: PurchaseOrderController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public PurchaseOrder Details(int id)
        {
            var data = purchaseOrderService.GetPurchaseOrderById(id);
            return data;
        }

        // GET: PurchaseOrderController/Create

        // POST: PurchaseOrderController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(PurchaseOrder model)
        {
            try
            {
                purchaseOrderService.AddPurchaseOrder(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: PurchaseOrderController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditPurchaseOrder")]
        public void Edit(int id, PurchaseOrder model)
        {
            try
            {
                purchaseOrderService.UpdatePurchaseOrder(model);
            }
            catch
            {
                return;
            }
        }

        // GET: PurchaseOrderController/Delete/5
        [HttpGet]
        [Route("PurchaseOrderDelete")]
        public string Delete(int id)
        {
            purchaseOrderService.DeletePurchaseOrder(id);

            return "Deleted Record Successfully";
        }

    }
}

