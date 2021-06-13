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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }
        public void Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
        }

        public void Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailDal.GetAll();
        }

        public OrderDetail GetById(int orderDetailId)
        {
            return _orderDetailDal.Get(o => o.Id == orderDetailId);
        }

        public void Uptade(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
        }
    }
}
