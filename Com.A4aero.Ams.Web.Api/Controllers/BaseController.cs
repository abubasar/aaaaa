using Com.A4aero.Ams.ApplicationService;
using Com.A4aero.Ams.DataModel;
using Com.A4aero.Ams.RequestModel;
using Com.A4aero.Ams.ViewModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Com.A4aero.Ams.Web.Api.Controllers
{
    [ApiController]
    public class BaseController<T, Tr, Tv> : ControllerBase where T : BaseEntity where Tr : BaseRequestModel<T> where Tv : BaseViewModel<T>
    {
        private readonly IBaseService<T, Tr, Tv> service;
        public BaseController(IBaseService<T, Tr, Tv> service)
        {
            this.service = service;
        }
        [HttpPost]
        [Route("search")]
        public IActionResult Search(Tr request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("please vi sob field fill up koren");
            }
            var searchResult = service.Search(request);
            return Ok(searchResult);
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost]
        [Route("add")]
        public IActionResult POST(T model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Bhai please sob field fill up koren");
            }

            model.CreatedOnUtc = DateTime.Now;

            var add = service.Add(model);
            return Ok(add);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut]
        [Route("edit")]
        public IActionResult PUT(T model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest("Bhai please sob field fill up koren");
            }
            model.UpdatedOnUtc = DateTime.Now;
            var edit = service.Edit(model);
            return Ok(edit);
        }

        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GET(long id)
        {
            var model = service.GetById(id);
            return Ok(model);
        }
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [Route("delete/{id}")]
        [HttpDelete]
        public IActionResult DELETE(long id)
        {
            var deleted = service.Delete(id);
            return Ok(deleted);
        }
    }
}
