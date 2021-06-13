using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }
        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public Person get(string name)
        {
            return _personDal.Get(p => p.UserName == name);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public bool Login(string userName, string password)
        {
            var result = _personDal.GetAll(p => p.UserName == userName && p.Password==password).Count;
            if (result==1)
            {
                return true;

            }
            else
            {
                return false;
            }
           
        }
    }
}
