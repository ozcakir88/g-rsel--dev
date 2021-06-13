using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrdersDal _orderdal;
        public OrderManager(IOrdersDal orderdal)
        {
            _orderdal = orderdal;
        }

        public void Add(Order order)
        {
            _orderdal.Add(order);
        }

        public List<Order> GetAll()
        {
            return _orderdal.GetAll();
        }

        public Order GetById(int orderId)
        {
            return _orderdal.Get(o => o.Id == orderId);
        }

        public List<OrderDTO> orderDTO()
        {
            return _orderdal.orderDTOs();
        }

        public void Update(Order order)
        {
            _orderdal.Update(order);
        }
    }
}
