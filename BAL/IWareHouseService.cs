using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IWareHouseService
    {
        IEnumerable<WareHouse> GetAllWareHouses();
        WareHouse GetWareHouseById(int id);
        void AddWareHouse(WareHouse wareHouse);
        void UpdateWareHouse(WareHouse wareHouse);
        void DeleteWareHouse(int id);

    }
}
