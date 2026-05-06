using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitofWork;

namespace BAL
{
    public class WareHouseService : IWareHouseService
    {
        private readonly IUnitofWork _unitOfWork;

        public WareHouseService(IUnitofWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public WareHouse GetWareHouseById(int id)
        {
            return _unitOfWork.WareHouseRepository.GetById(id);
        }




        public void AddWareHouse(WareHouse wareHouse)
        {
            _unitOfWork.WareHouseRepository.Add(wareHouse);
            _unitOfWork.SaveChanges();
        }

        public void UpdateWareHouse(WareHouse wareHouse)
        {
            _unitOfWork.WareHouseRepository.Update(wareHouse);
            _unitOfWork.SaveChanges();
        }

        public void DeleteWareHouse(int id)
        {
            _unitOfWork.WareHouseRepository.Delete(id);
            _unitOfWork.SaveChanges();
        }

        public IEnumerable<WareHouse> GetAllWareHouses()
        {
            return _unitOfWork.WareHouseRepository.GetAll();
        }
    }
}
