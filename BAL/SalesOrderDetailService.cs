using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class SalesOrderDetailService : ISalesOrderDetailService
    {
        private readonly IUnitofWork _unitOfWork;

        public SalesOrderDetailService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public SalesOrderDetail GetSalesOrderDetailById(int id)
        {
            return _unitOfWork.SalesOrderDetailRepository.GetById(id);
        }




        public void AddSalesOrderDetail(SalesOrderDetail salesOrderDetail)
        {
            _unitOfWork.SalesOrderDetailRepository.Add(salesOrderDetail);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSalesOrderDetail(SalesOrderDetail salesOrderDetail)
        {
            _unitOfWork.SalesOrderDetailRepository.Update(salesOrderDetail);
            _unitOfWork.SaveChanges();
        }

        public void DeleteSalesOrderDetail(int id)
        {
            _unitOfWork.SalesOrderDetailRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<SalesOrderDetail> GetAllSalesOrderDetails()
        {
            return _unitOfWork.SalesOrderDetailRepository.GetAll();
        }

    }
}
