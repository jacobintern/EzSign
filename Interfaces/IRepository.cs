using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EzSign.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        bool Create(TEntity instance);

        bool Update(TEntity instance);

        bool Delete(TEntity instance);

        bool Any(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        void Add(TEntity instance);

        bool Save();

        Task<bool> AsyncSave();
    }
}