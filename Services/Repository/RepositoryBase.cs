﻿using DAO;
using Microsoft.EntityFrameworkCore;
using Services.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Services
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected MusicShopDbContext context;
        public RepositoryBase(MusicShopDbContext musicShopDbContext)
        {
            context = musicShopDbContext;
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
        public IList<T> ListAll()
        {
            return context.Set<T>().ToList();
        }
        public int Update(T entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return context.SaveChanges();
        }

        public int Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges();
        }

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
