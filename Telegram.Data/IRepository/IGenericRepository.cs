﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Telegram.Data.IRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate);

        Task<T> CreateAsynce(T entity);
    }
}
