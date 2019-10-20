﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
    }
}
