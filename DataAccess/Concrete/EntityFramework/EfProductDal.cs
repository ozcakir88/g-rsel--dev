using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoriBase<Product, ETicaretContext>, IProductDal
    {


        List<ProductDTO> IProductDal.productDetailDtos()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from p in context.products
                             join c in context.categories  on p.CategoryId equals c.Id
                             join b in context.Brands  on p.BrandId equals b.Id
                             select new ProductDTO
                             {
                                 Id = p.Id,
                                 Name = p.Name,
                                 CategoryName = c.CategoryName,
                                 Stock = p.Stock,
                                 Code=p.Code,
                                 BrandName=b.BrandName,
                                 Price=p.Price,
                                 CreateDate=p.CreateDate,
                                 Active=p.Active
                                 
                             };
                return result.ToList();

            }
        }
    }
    }
