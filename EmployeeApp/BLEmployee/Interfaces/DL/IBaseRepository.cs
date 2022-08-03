﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BL.Interfaces.DL
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
