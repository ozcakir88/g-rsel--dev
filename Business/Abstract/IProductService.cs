using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnirPrice(decimal min, decimal max);
        List<ProductDTO> productDTO();
       void Delete(Product product);
        void Add(Product product);
        void Update(Product product);
        List<Product> GetByProductName(string productName);
        Product GetById(int productId);

       


    }
}
