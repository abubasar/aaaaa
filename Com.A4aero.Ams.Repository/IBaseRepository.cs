using Com.A4aero.Ams.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.A4aero.Ams.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        bool Add(T entity);
        IQueryable<T> Get();
        T GetDetail(long id);
        bool Edit(T entity);
        bool Delete(long id);
    }
}