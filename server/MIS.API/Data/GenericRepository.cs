using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MIS.API.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DataContext context;
        private readonly DbSet<T> db;
        public GenericRepository(DataContext context)
        {
            this.context = context;
            this.db = this.context.Set<T>();
            
        }

        public void Create(T entity)
        {
            db.Add(entity);
        }

        public void Delete(T entity)
        {
            if(entity != null)
                db.Remove(entity);
            
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await db.Where(match).SingleOrDefaultAsync();
        }

        public IQueryable<T> GetAll()
        {
            return db.AsQueryable();
        }

        public async Task<T> GetById(int id)
        {
            return await db.FindAsync(id);
        }

        public async Task SaveAsync()
        {
           await context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            if(entity !=null)
                db.Update(entity);
        }
    }
}