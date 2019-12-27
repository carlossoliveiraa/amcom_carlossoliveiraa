using System;
using AmCom.Application.Dto;
using AmCom.Application.Interfaces;
using AmCom.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AmCom.Service.Api.Controllers
{
    /// <summary>
    /// SOLID - Dependency Inversion - Usar Injecao de Dependecias
    /// </summary>

    [Produces("application/json")]
    [Route("api/[controller]")]
    //[Authorize()]
    public class BaseController<Entidade, EntidadeDTO> : Controller 
        where Entidade : BaseEntity 
        where EntidadeDTO : DtoBase
    {
        private readonly IAppBase<Entidade, EntidadeDTO> app;

        public BaseController(IAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Get()
        {
            try
            {
                var obj = app.GetAll();
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var obj = app.GetById(id);
                return new OkObjectResult(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody]  EntidadeDTO obj)
        {
            try
            {
                return new OkObjectResult(app.Create(obj));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] EntidadeDTO obj)
        {
            try
            {
                app.Update(obj);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                app.Delete(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}