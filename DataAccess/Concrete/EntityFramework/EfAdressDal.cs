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
   public class EfAdressDal : EfEntityRepositoriBase<Adress, ETicaretContext>, IAddressDal
    {
       


        //List<AdressDTO> IAddressDal.adressDtos()
        //{
        //    using (ETicaretContext context = new ETicaretContext())
        //    {
        //        var result = from a in context.Adress
        //                     join u in context.Users on a.UserId equals u.Id
        //                     join c in context.Cities on a.CityId equals c.Id
        //                       join co in context.Countries  on c.CountryId equals co.Id
        //                     select new AdressDTO
        //                     {
        //                         Id = a.Id,
        //                         UserName = u.UserName,
        //                         adresText = a.AdressText,
        //                         City = c.Name,
        //                        CountryName=co.Name


        //                     };
        //        return result.ToList();

        //    }
        //}
    }
}
