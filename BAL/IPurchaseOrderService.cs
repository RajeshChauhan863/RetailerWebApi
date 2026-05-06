using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IPurchaseOrderService
    {

        IEnumerable<PurchaseOrder> GetAllPurchaseOrders();
        PurchaseOrder GetPurchaseOrderById(int id);
        void AddPurchaseOrder(PurchaseOrder product);
        void UpdatePurchaseOrder(PurchaseOrder product);
        void DeletePurchaseOrder(int id);
    }
}
