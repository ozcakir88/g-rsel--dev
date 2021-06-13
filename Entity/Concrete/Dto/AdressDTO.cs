using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete.Dto
{
 public   class AdressDTO:IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string adresText { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
    }
}
