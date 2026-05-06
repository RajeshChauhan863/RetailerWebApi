using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface ISalesOrderService
    {
        IEnumerable<SalesOrder> GetAllSalesOrder();
        SalesOrder GetSalesOrderById(int id);
        void AddSalesOrder(SalesOrder salesOrder);
        void UpdateSalesOrder(SalesOrder salesOrder);
        void DeleteSalesOrder(int id);

    }
}
