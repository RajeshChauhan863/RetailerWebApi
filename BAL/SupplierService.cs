using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class SupplierService : ISupplierService
    {
        private readonly IUnitofWork _unitOfWork;

        public SupplierService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Supplier GetSupplierById(int id)
        {
            return _unitOfWork.SupplierRepository.GetById(id);
        }




        public void AddSupplier(Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Add(supplier);
            _unitOfWork.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _unitOfWork.SupplierRepository.Update(supplier);
            _unitOfWork.SaveChanges();
        }

        public void DeleteSupplier(int id)
        {
            _unitOfWork.SupplierRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _unitOfWork.SupplierRepository.GetAll();
        }

    }
}
