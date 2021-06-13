using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public void Add(Citys city)
        {
            _cityDal.Add(city);
        }

        public List<CityDTO> cityDTO()
        {
            return _cityDal.cityDTOs();
        }

        public void Delete(Citys city)
        {
            _cityDal.Delete(city);
        }

        public List<Citys> GetAll()
        {
            return _cityDal.GetAll();
        }

        public Citys GetById(int cityId)
        {
            return _cityDal.Get(c => c.Id == cityId);
        }

        public void Uptade(Citys city)
        {
            _cityDal.Update(city);
        }
    }
}
