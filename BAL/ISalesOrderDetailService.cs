using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface ISalesOrderDetailService
    {
        IEnumerable<SalesOrderDetail> GetAllSalesOrderDetails();
        SalesOrderDetail GetSalesOrderDetailById(int id);
        void AddSalesOrderDetail(SalesOrderDetail salesOrder);
        void UpdateSalesOrderDetail(SalesOrderDetail salesOrder);
        void DeleteSalesOrderDetail(int id);

    }
}
