using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IOrderStatusService
    {
        List<OrderStatus> GetAll();
        OrderStatus GetById(int OrderStatusId);
        void Add(OrderStatus orderStatus);
        void Uptade(OrderStatus orderStatus);
        void Delete(OrderStatus orderStatus);
    }
}
