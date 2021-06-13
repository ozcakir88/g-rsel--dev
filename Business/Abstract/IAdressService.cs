using Entity.Concrete;
using Entity.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IAdressService
    {
        List<Adress> GetAll();
        List<Adress> GetAll(int userId);
        Adress Get(string adrestext);
      //  List<AdressDTO> adressDTO();
        Adress GetById(int adressId);
        void Add(Adress adress);
        void Uptade(Adress adress);
        void Delete(Adress adress);
    }
}
