using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Telegram.Data.Contexts;
using Telegram.Data.IRepository;

namespace Telegram.Data.Repositroy
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
#pragma warning disable

        private readonly TelegramDbContext db;

        private DbSet<T> dbSet { get; set; }

        public GenericRepository(TelegramDbContext telegramDbContext)
        {
            db = telegramDbContext;
            dbSet = db.Set<T>();
        }

        public async Task<T> CreateAsynce(T entity)
        {
            EntityEntry entityEntry = await dbSet.AddAsync(entity);
            await db.SaveChangesAsync();
            return (T)entityEntry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            T entity = await dbSet.FirstOrDefaultAsync(predicate);
            if (entity is null) return false;
            dbSet.Remove(entity);
            await db.SaveChangesAsync();
            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? dbSet : dbSet.Where(predicate);
        }


        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            await db.SaveChangesAsync();
            return entity;
        }
    }
}
