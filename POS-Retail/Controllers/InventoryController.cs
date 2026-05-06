using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        IinventoryService inventoryService;

        public InventoryController(IinventoryService _inventoryService)
        {
            inventoryService = _inventoryService;

        }



        // GET: CustomerController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public Inventory Details(int id)
        {
            var data = inventoryService.GetInventoryById(id);
            return data;
        }

        // GET: CustomerController/Create

        // POST: CustomerController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(Inventory model)
        {
            try
            {
                inventoryService.AddInventory(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: CustomerController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditInventory")]
        public void Edit(int id, Inventory model)
        {
            try
            {
                inventoryService.UpdateInventory(model);
            }
            catch
            {
                return;
            }
        }

        // GET: CustomerController/Delete/5
        [HttpGet]
        [Route("InventoryDelete")]
        public string Delete(int id)
        {
            inventoryService.DeleteInventory(id);

            return "Deleted Record Successfully";
        }

    }
}
