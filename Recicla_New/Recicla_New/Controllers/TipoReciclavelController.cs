
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
    public class TipoReciclavelController : ControllerBase
    {
        readonly ITipoReciclavelApplication _tipoReciclavelsRepository;

        public TipoReciclavelController(ITipoReciclavelApplication tipoReciclavelsRepository)
        {
            _tipoReciclavelsRepository = tipoReciclavelsRepository;
        }

        [HttpGet]
        public IActionResult GetTiposReciclaveis()
        {
            try
            {
                var tipoReciclavel = _tipoReciclavelsRepository.GetTiposReciclaveis();
                return Ok(tipoReciclavel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetTipoReciclavels(int id)
        {
            try
            {
                var tipoReciclavel = _tipoReciclavelsRepository.GetTipoReciclavel(id);
                return Ok(tipoReciclavel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteTipoReciclavel(int id)
        {
            try
            {
                _tipoReciclavelsRepository.DeleteTipoReciclavel(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
