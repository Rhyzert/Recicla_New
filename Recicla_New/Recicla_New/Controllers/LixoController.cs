
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
    public class LixoController : ControllerBase
    {
        readonly ILixoApplication _lixoApplication;

        public LixoController(ILixoApplication lixoApplication)
        {
            _lixoApplication = lixoApplication;
        }

        [HttpGet]
        public IActionResult GetLixo()
        {
            try
            {
                var lixo = _lixoApplication.GetLixos();
                return Ok(lixo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetLixos(int id)
        {
            try
            {
                var lixo = _lixoApplication.GetLixo(id);
                return Ok(lixo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertLixo(Lixo lixo)
        {
            try
            {
                _lixoApplication.InsertLixo(lixo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateLixo(Lixo lixo)
        {
            try
            {
                _lixoApplication.UpdateLixo(lixo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLixo(int id)
        {
            try
            {
                _lixoApplication.DeleteLixo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
