using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface ICountryService
    {
        List<Country> GetAll();
        Country GetById(int countryId);
        void Add(Country country);
        void Uptade(Country country);
        void Delete(Country country);
    }
}
