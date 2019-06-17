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
    [Route("api/markup-plan")]
    public class MarkupPlanController : BaseController<MarkupPlan, MarkupPlanRequestModel, MarkupPlanViewModel>
    {
        public MarkupPlanController(IBaseService<MarkupPlan, MarkupPlanRequestModel, MarkupPlanViewModel> service) : base(service)
        {
        }
    }
}
