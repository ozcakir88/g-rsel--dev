using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IBasketService
    {
        List<Basket> GetAll();
        List<Basket> GetAll(int userId);
        Basket GetById(int basketId);
        void Add(Basket basket);
        void Uptade(Basket basket);
        void Delete(Basket basket);
    }
}
