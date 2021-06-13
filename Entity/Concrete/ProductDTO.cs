using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
  public  class ProductDTO:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string  BrandName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Decimal Price { get; set; }
        public int Stock { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Active { get; set; }
    }
}
