using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
  public  class Person:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string   Tel { get; set; }

        public DateTime CreateDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
