using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
   public class Product:IEntity
    {
        public int Id { get; set; } 
        public int  CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public Boolean Active { get; set; }
        public int Stock { get; set; }

    }
}
