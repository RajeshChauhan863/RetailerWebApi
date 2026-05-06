using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly IUnitofWork _unitOfWork;

        public SalesOrderService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public SalesOrder GetSalesOrderById(int id)
        {
            return _unitOfWork.SalesOrderRepository.GetById(id);
        }




        public void AddSalesOrder(SalesOrder salesOrder)
        {
            _unitOfWork.SalesOrderRepository.Add(salesOrder);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSalesOrder(SalesOrder salesOrder)
        {
            _unitOfWork.SalesOrderRepository.Update(salesOrder);
            _unitOfWork.SaveChanges();
        }

        public void DeleteSalesOrder(int id)
        {
            _unitOfWork.SalesOrderRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<SalesOrder> GetAllSalesOrder()
        {
            return _unitOfWork.SalesOrderRepository.GetAll();
        }
    }
}
