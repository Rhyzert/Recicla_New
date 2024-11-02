
using ApplicationService.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ColetaController : ControllerBase
    {
        readonly IColetaApplication _coletaApplication;

        public ColetaController(IColetaApplication coletaApplication)
        {
           _coletaApplication = coletaApplication;
        }

        [HttpGet]
        public IActionResult GetColeta()
        {
            try
            {
                var coleta = _coletaApplication.GetColetas();
                return Ok(coleta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetColetas(int id)
        {
            try
            {
                var coleta = _coletaApplication.GetColeta(id);
                return Ok(coleta);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertColeta(Coleta coleta)
        {
            try
            {
                _coletaApplication.InsertColeta(coleta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateColeta(Coleta coleta)
        {
            try
            {
                _coletaApplication.UpdateColeta(coleta);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteColeta(int id)
        {
            try
            {
                _coletaApplication.DeleteColeta(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
