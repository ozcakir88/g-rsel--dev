using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CountryManager : ICountryService
    {
        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public void Add(Country country)
        {
            _countryDal.Add(country);
        }

        public void Delete(Country country)
        {
            _countryDal.Delete(country);
        }

        public List<Country> GetAll()
        {
            return _countryDal.GetAll();
        }

        public Country GetById(int countryId)
        {
            return _countryDal.Get(c => c.Id == countryId);
        }

        public void Uptade(Country country)
        {
            _countryDal.Update(country);
        }
    }
}
