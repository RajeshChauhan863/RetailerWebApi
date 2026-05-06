using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        ISupplierService supplierService;

        public SupplierController(ISupplierService _supplierService)
        {
            supplierService = _supplierService;

        }



        // GET: SupplierController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Supplier Details(int id)
        {
            var data = supplierService.GetSupplierById(id);
            return data;
        }

        // GET: SupplierController/Create

        // POST: SupplierController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Supplier model)
        {
            try
            {
                supplierService.AddSupplier(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: SupplierController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditSupplier")]
        public void Edit(int id, Supplier model)
        {
            try
            {
                supplierService.UpdateSupplier(model);
            }
            catch
            {
                return;
            }
        }

        // GET: SupplierController/Delete/5
        [HttpGet]
        [Route("SupplierDelete")]
        public string Delete(int id)
        {
            supplierService.DeleteSupplier(id);

            return "Deleted Record Successfully";
        }
    }
}
