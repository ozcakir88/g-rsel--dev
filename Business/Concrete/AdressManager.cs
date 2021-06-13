using Business.Abstract;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdressManager : IAdressService
    {
        IAddressDal _adresDal;

        public AdressManager(IAddressDal addressDal)
        {
            _adresDal = addressDal;
        }
        public void Add(Adress adress)
        {
            _adresDal.Add(adress);
        }

       

        public void Delete(Adress adress)
        {
            _adresDal.Delete(adress);
        }

        public List<Adress> GetAll()
        {
            return _adresDal.GetAll();
        }

        public List<Adress> GetAll(int userId)
        {
            return _adresDal.GetAll(a => a.UserId == userId);
        }

        public Adress Get(string adrestext)
        {
            return _adresDal.Get(a => a.AdresText == adrestext);
        }

        public Adress GetById(int adressId)
        {
            return _adresDal.Get(a => a.Id == adressId);
        }

        public void Uptade(Adress adress)
        {
            _adresDal.Update(adress);
        }
    }
}
