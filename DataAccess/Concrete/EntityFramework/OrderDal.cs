using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class OrderDal : EfEntityRepositoriBase<Order, ETicaretContext>, IOrdersDal
    {
        public List<OrderDTO> orderDTOs()
        {
            using (ETicaretContext context = new ETicaretContext())
            {
                var result = from o in context.Orders
                             join u in context.Users on o.UserId equals u.Id
                             join a in context.Adress on o.AdressId equals a.Id
                             join s in context.OrderStatuses on o.OrderStatusId equals s.Id

                             select new OrderDTO
                             {
                                 Id=o.Id,
                                 UserName=u.UserName,
                                 AdresText=a.AdresText,
                                 OrderSatatusName=s.Name,
                                 Count=o.Count,
                                 CreateDate=o.CreateDate,
                                 Active=o.Active

                             };
                return result.ToList();

            }
        }
    }
}
