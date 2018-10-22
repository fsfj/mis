using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MIS.API.Data
{
    public interface IGenericRepository<T> where T: class
    {
         IQueryable<T> GetAll();
         Task<T> GetById(int id);
         Task<T> FindAsync(Expression<Func<T, bool>> match);
         void Create(T entity);
         void Update(T entity);
         void Delete(T entity);
         Task SaveAsync();
    }
}