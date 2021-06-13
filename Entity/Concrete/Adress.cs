using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
  public  class Adress:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string AdresText { get; set; }
     
        public DateTime CreateDate { get; set; }
        public bool Active { get; set; }



    }
}
