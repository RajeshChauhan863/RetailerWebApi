using DAL.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class PurchaseOrderDetailService : IPurchaseOrderDetailService
    {
        private readonly IUnitofWork _unitOfWork;

        public PurchaseOrderDetailService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PurchaseOrderDetail GetPurchaseOrderDetailById(int id)
        {
            return _unitOfWork.PurchaseOrderDetailRepository.GetById(id);
        }





        public void AddPurchaseOrderDetail(PurchaseOrderDetail purchaseOrderDetail)
        {
            _unitOfWork.PurchaseOrderDetailRepository.Add(purchaseOrderDetail);
            _unitOfWork.SaveChanges();
        }

        public void UpdatePurchaseOrderDetail(PurchaseOrderDetail purchaseOrderDetail)
        {
            _unitOfWork.PurchaseOrderDetailRepository.Update(purchaseOrderDetail);
            _unitOfWork.SaveChanges();
        }

        public void DeletePurchaseOrderDetail(int id)
        {
            _unitOfWork.PurchaseOrderDetailRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<PurchaseOrderDetail> GetAllPurchaseOrderDetails()
        {
            return _unitOfWork.PurchaseOrderDetailRepository.GetAll();
        }
    }
}
