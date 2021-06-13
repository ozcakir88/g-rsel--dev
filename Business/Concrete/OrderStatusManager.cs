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
    public class OrderStatusManager : IOrderStatusService
    {
        IOrderStatusDal _orderStatusDal;
        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }
        public void Add(OrderStatus orderStatus)
        {
            _orderStatusDal.Add(orderStatus);
        }

        public void Delete(OrderStatus orderStatus)
        {
            _orderStatusDal.Delete(orderStatus);
        }

        public List<OrderStatus> GetAll()
        {
            return _orderStatusDal.GetAll();
        }

        public OrderStatus GetById(int OrderStatusId)
        {
            return _orderStatusDal.Get(o => o.Id == OrderStatusId);
        }

        public void Uptade(OrderStatus orderStatus)
        {
            _orderStatusDal.Update(orderStatus);
        }
    }
}
