
using EzSign.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace EzSign.Models.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly EzSignDBContext _dbContext;

        public Repository(EzSignDBContext ezSignDBContext) => _dbContext = ezSignDBContext;

        public bool Create(TEntity instance)
        {
            _dbContext.Set<TEntity>().Add(instance);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Update(TEntity instance)
        {
            _dbContext.Entry(instance).State = EntityState.Modified;
            _dbContext.Set<TEntity>().Find(instance);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(TEntity instance)
        {
            _dbContext.Entry(instance).State = EntityState.Deleted;
            return _dbContext.SaveChanges() > 0;
        }

        [System.Obsolete]
        public bool DeleteAll(TEntity instance)
        {
            string tableName = instance.GetType().Name;
            return _dbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE " + tableName) > 0;
        }

        public bool Any(Expression<Func<TEntity, bool>> pre) => _dbContext.Set<TEntity>().Any(pre);

        public void Add(TEntity instance) => _dbContext.Set<TEntity>().Add(instance);

        public IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> pre) => _dbContext.Set<TEntity>().Where(pre).AsQueryable();

        public IQueryable<TEntity> GetAll() => _dbContext.Set<TEntity>().AsQueryable();

        public bool Save() => this._dbContext.SaveChanges() > 0;

        public async Task<bool> AsyncSave() => await this._dbContext.SaveChangesAsync() > 0;

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dis)
        {
            if (this._dbContext != null && dis)
            {
                this._dbContext.Dispose();
            }
        }
    }
}