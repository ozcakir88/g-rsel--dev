using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Get(int userId)
        {
            return _userDal.Get(u => u.Id == userId);
        }

        public User get(string name)
        {
            return _userDal.Get(p => p.UserName == name);
        }


        public bool Login(string userName, string password)
        {
            var result = _userDal.GetAll(u =>u.UserName  == userName && u.Password== password).Count;
            if (result == 1)
            {
                return true;

            }
            else
            {
                return false;
            }

        }
        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }
    }
}
