﻿using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {

        List<Category> GetAll();
        Category GetById(int categoryId);
        void Add(Category category);
        void Uptade(Category category);
        void Delete(Category category);
        

    }
}
