
using ApplicationService.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    
    [ApiController]
    public class ColetadorController : ControllerBase
    {
        readonly IColetadorApplication _coletadorApplication;

        public ColetadorController(IColetadorApplication coletadorApplication)
        {
            _coletadorApplication = coletadorApplication;
        }

        [HttpGet]
        public IActionResult GetColetador()
        {
            try
            {
                var coletador = _coletadorApplication.GetColetadores();
                return Ok(coletador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetColetadors(int id)
        {
            try
            {
                var coletador = _coletadorApplication.GetColetador(id);
                return Ok(coletador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertColetador(Coletador coletador)
        {
            try
            {
                _coletadorApplication.InsertColetador(coletador);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateColetador(Coletador coletador)
        {
            try
            {
                _coletadorApplication.UpdateColetador(coletador);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteColetador(int id)
        {
            try
            {
                _coletadorApplication.DeleteColetador(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
