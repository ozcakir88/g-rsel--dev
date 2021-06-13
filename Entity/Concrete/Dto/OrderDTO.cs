using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Dto
{
  public  class OrderDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public  string AdresText{ get; set; }
        public string OrderSatatusName { get; set; }
        public int Count { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }


    }
}
