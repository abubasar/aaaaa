using Com.A4aero.Ams.ApplicationService;
using Com.A4aero.Ams.DataModel;
using Com.A4aero.Ams.RequestModel;
using Com.A4aero.Ams.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.A4aero.Ams.Web.Api.Controllers
{
    [Route("api/business-entity")]
    public class BusinessEntityController : BaseController<BusinessEntity, BusinessEntityRequestModel, BusinessEntityViewModel>
    {
        public BusinessEntityController(IBaseService<BusinessEntity, BusinessEntityRequestModel, BusinessEntityViewModel> service) : base(service)
        {

        }
    }
}
