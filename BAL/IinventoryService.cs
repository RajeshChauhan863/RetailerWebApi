using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IinventoryService
    {
        IEnumerable<Inventory> GetAllInventory();
        Inventory GetInventoryById(int id);
        void AddInventory(Inventory product);
        void UpdateInventory(Inventory product);
        void DeleteInventory(int id);

    }
}
