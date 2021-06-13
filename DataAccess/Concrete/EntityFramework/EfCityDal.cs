using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : EfEntityRepositoriBase<Citys, ETicaretContext>, ICityDal
    {
        public List<CityDTO> cityDTOs()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from c in context.Cities
                             join co in context.Countries on c.CountryId equals co.Id
                             select new CityDTO
                             {
                                Id=c.Id,
                                CityName=c.Name,
                                CountryName=co.Name


                             };
                return result.ToList();

            }
        }
    }
}
