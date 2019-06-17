using Com.A4aero.Ams.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Com.A4aero.Ams.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AmsContext context;
        public BaseRepository(AmsContext context)
        {
            this.context = context;
        }

        public bool Add(T entity)
        {

            DbSet<T> dbSet = this.context.Set<T>();
            dbSet.Add(entity);
            int i = context.SaveChanges();
            return i > 0;
        }


        public IQueryable<T> Get()
        {
           
            DbSet<T> dbSet = this.context.Set<T>();
            return dbSet.AsQueryable();
        }

        public T GetDetail(long id)
        {
            return this.context.Set<T>().Find(id);

        }



        public bool Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            int i = context.SaveChanges();
            return i > 0;
        }

        public bool Delete(long id)
        {
            var entity = GetDetail(id);
            if (entity != null)
            {
                context.Set<T>().Remove(entity);
                int i = context.SaveChanges();
                return i > 0;
            }
            return true;
        }
    }
}
