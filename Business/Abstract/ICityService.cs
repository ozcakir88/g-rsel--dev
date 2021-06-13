using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICityService
    {
        List<Citys> GetAll();
        List<CityDTO> cityDTO();
        Citys GetById(int cityId);
        void Add(Citys city);
        void Uptade(Citys city);
        void Delete(Citys city);
    }
}
