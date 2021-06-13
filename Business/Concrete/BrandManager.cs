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
    public class BrandManager : IBrandService
    {
        IBrandDal _branddal;
        public BrandManager(IBrandDal branddal)
        {
            _branddal = branddal;
        }

        public void Add(Brand brand)
        {
            _branddal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _branddal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _branddal.GetAll();

        }

        public Brand GetById(int brandId)
        {
            return _branddal.Get(b=>b.Id==brandId);
        }

        public void Uptade(Brand brand)
        {
            _branddal.Update(brand);
        }
    }
}
