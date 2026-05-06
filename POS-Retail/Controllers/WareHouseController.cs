using BAL;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POS_Retail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WareHouseController : ControllerBase
    {
        IWareHouseService wareHouseService;

        public WareHouseController(IWareHouseService _wareHouseService)
        {
            wareHouseService = _wareHouseService;

        }



        // GET: WareHouseController/Details/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        public WareHouse Details(int id)
        {
            var data = wareHouseService.GetWareHouseById(id);
            return data;
        }

        // GET: WareHouseController/Create

        // POST: WareHouseController/Create
        [Microsoft.AspNetCore.Mvc.HttpPost]

        public void Create(WareHouse model)
        {
            try
            {
                wareHouseService.AddWareHouse(model);
            }
            catch (Exception ex)
            {
                return;
            }
        }


        // POST: WareHouseController/Edit/5
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Route("EditWareHouse")]
        public void Edit(int id, WareHouse model)
        {
            try
            {
                wareHouseService.UpdateWareHouse(model);
            }
            catch
            {
                return;
            }
        }

        // GET: WareHouseController/Delete/5
        [HttpGet]
        [Route("WareHouseDelete")]
        public string Delete(int id)
        {
            wareHouseService.DeleteWareHouse(id);

            return "Deleted Record Successfully";
        }
    }
}
