using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Citys : IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int Active { get; set; }


    }
}
