using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
  public  class Order:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AdressId { get; set; }
        public int OrderStatusId { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }




    }
}
