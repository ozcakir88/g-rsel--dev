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
    public class ProductManager : IProductService
    {
        IProductDal _productdal;
      
        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;
            
        }
        public void Add(Product product)
        {
            _productdal.Add(product);
        }

        public void Delete(Product product)
        {
            _productdal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productdal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productdal.GetAll(p => p.CategoryId == id);
        }

        public Product GetById(int productId)
        {
          return  _productdal.Get(p => p.Id == productId);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productdal.GetAll(p=>p.Name==productName);
        }

        public List<Product> GetByUnirPrice(decimal min, decimal max)
        {
           return _productdal.GetAll(p => p.Price >= min && p.Price <= max);
        }

        public List<ProductDTO> productDTO()
        {
            return _productdal.productDetailDtos(); 
        }

        public void Update(Product product)
        {
            _productdal.Update(product);
        }
    }
}
