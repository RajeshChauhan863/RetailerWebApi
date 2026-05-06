using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IPurchaseOrderDetailService
    {

        IEnumerable<PurchaseOrderDetail> GetAllPurchaseOrderDetails();
        PurchaseOrderDetail GetPurchaseOrderDetailById(int id);
        void AddPurchaseOrderDetail(PurchaseOrderDetail product);
        void UpdatePurchaseOrderDetail(PurchaseOrderDetail product);
        void DeletePurchaseOrderDetail(int id);
    }
}
