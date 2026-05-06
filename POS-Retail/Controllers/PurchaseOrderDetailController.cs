using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderDetailController : ControllerBase
    {
        IPurchaseOrderDetailService purchaseOrderDetailService;

        public PurchaseOrderDetailController(IPurchaseOrderDetailService _purchaseOrderDetailService)
        {
            purchaseOrderDetailService = _purchaseOrderDetailService;

        }



        // GET: PurchaseOrderDetailController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public PurchaseOrderDetail Details(int id)
        {
            var data = purchaseOrderDetailService.GetPurchaseOrderDetailById(id);
            return data;
        }

        // GET: PurchaseOrderDetailController/Create

        // POST: PurchaseOrderDetailController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(PurchaseOrderDetail model)
        {
            try
            {
                purchaseOrderDetailService.AddPurchaseOrderDetail(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: PurchaseOrderDetailController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditPurchaseOrderDetail")]
        public void Edit(int id, PurchaseOrderDetail model)
        {
            try
            {
                purchaseOrderDetailService.UpdatePurchaseOrderDetail(model);
            }
            catch
            {
                return;
            }
        }

        // GET: PurchaseOrderDetailController/Delete/5
        [HttpGet]
        [Route("PurchaseOrderDetailDelete")]
        public string Delete(int id)
        {
            purchaseOrderDetailService.DeletePurchaseOrderDetail(id);

            return "Deleted Record Successfully";
        }


    }
}
