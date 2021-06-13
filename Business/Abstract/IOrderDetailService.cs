using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        OrderDetail GetById(int orderDetailId);
        void Add(OrderDetail orderDetail);
        void Uptade(OrderDetail orderDetail);
        void Delete(OrderDetail orderDetail);
    }
}
