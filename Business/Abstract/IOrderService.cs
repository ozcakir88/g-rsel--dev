﻿using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IOrderService
    {
        List<Order> GetAll();
        List<OrderDTO> orderDTO();
        void Add(Order order);
        void Update(Order order);
        Order GetById(int orderId);
    }
}
