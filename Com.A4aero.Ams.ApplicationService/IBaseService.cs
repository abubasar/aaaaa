using Com.A4aero.Ams.DataModel;
using Com.A4aero.Ams.RequestModel;
using Com.A4aero.Ams.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.A4aero.Ams.ApplicationService
{
    public interface IBaseService<T, Tr, Tv> where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>

    {
        IQueryable<T> SearchQueryable(BaseRequestModel<T> request);
        bool Add(T model);
        bool Edit(T model);
        Tv Detail(long id);
        T GetById(long id);
        List<Tv> Search(Tr request);

        bool Delete(long id);


    }
}


