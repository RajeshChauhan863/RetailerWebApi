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
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IUnitofWork _unitOfWork;

        public PurchaseOrderService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public PurchaseOrder GetPurchaseOrderById(int id)
        {
            return _unitOfWork.PurchaseOrderRepository.GetById(id);
        }




        public void AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _unitOfWork.PurchaseOrderRepository.Add(purchaseOrder);
            _unitOfWork.SaveChanges();
        }

        public void UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _unitOfWork.PurchaseOrderRepository.Update(purchaseOrder);
            _unitOfWork.SaveChanges();
        }

        public void DeletePurchaseOrder(int id)
        {
            _unitOfWork.PurchaseOrderRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<PurchaseOrder> GetAllPurchaseOrders()
        {
            return _unitOfWork.PurchaseOrderRepository.GetAll();
        }

    }
}
