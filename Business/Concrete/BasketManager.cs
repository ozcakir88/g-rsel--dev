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
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public void Add(Basket basket)
        {
            _basketDal.Add(basket);
        }

        public void Delete(Basket basket)
        {
            _basketDal.Delete(basket);
        }

        public List<Basket> GetAll()
        {
            return _basketDal.GetAll();
        }

        public List<Basket> GetAll(int userId)
        {
            return _basketDal.GetAll(b => b.UserId == userId);
        }

        public Basket GetById(int basketId)
        {
            return _basketDal.Get(b => b.ProductId == basketId);
        }

        public void Uptade(Basket basket)
        {
            _basketDal.Update(basket);
        }
    }
}
