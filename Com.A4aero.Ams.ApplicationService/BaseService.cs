using Com.A4aero.Ams.DataModel;
using Com.A4aero.Ams.Repository;
using Com.A4aero.Ams.RequestModel;
using Com.A4aero.Ams.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Com.A4aero.Ams.ApplicationService
{
    public class BaseService<T, Tr, Tv> : IBaseService<T, Tr, Tv> where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {

        private readonly IBaseRepository<T> repository;
        public BaseService(IBaseRepository<T> repository)
        {
            this.repository = repository;
        }


        public IQueryable<T> SearchQueryable(BaseRequestModel<T> request)
        {
            IQueryable<T> queryable = repository.Get();
            queryable = request.IncludeParents(queryable);
            var expression = request.GetExpression();
            queryable = queryable.Where(expression);
            queryable = request.OrderByFunc()(queryable);
            queryable = request.SkipAndTake(queryable);
            queryable = request.IncludeParents(queryable);

            return queryable;
        }

        public bool Add(T model)
        {

            return repository.Add(model);
        }

        public bool Edit(T model)
        {

            return repository.Edit(model);
        }

        public T GetById(long id)
        {

            return repository.GetDetail(id);
        }


        public bool Delete(long id)
        {

            return repository.Delete(id);
        }

        public Tv Detail(long id)
        {
            T x = repository.GetDetail(id);

            if (x == null)
          
            {
                throw new Exception();
            }

            var vm = CreateVmInstance(x);

            return vm;
        }

        public List<Tv> Search(Tr request)
        {

            var queryable = SearchQueryable(request);

            var list = queryable.ToList().ConvertAll(CreateVmInstance); 

            return list;
        }

        private static Tv CreateVmInstance(T x)
        {
            return (Tv)Activator.CreateInstance(typeof(Tv), x);
        }

    }
}