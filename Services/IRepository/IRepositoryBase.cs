﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services.IRepository
{
    public interface IRepositoryBase<T>
    {
        T Get(int id);
        IList<T> ListAll();
        int Update(T entity);
        int Delete(T entity);
        T Add(T entity);
    }
}
