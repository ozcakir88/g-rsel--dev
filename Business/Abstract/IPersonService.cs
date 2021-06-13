using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IPersonService
    {
        void Add(Person person);
        List<Person> GetAll();
        Person get(string name);
        bool Login(string userName, string password);

    }
}
