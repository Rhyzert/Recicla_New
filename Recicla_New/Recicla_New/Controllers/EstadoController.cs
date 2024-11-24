
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
    public class EstadoController : ControllerBase
    {
        readonly IEstadoApplication _estadoApplication;

        public EstadoController(IEstadoApplication estadoApplication)
        {
            _estadoApplication = estadoApplication;
        }

        [HttpGet]
        public IActionResult GetEstado()
        {
            try
            {
                var estado = _estadoApplication.GetEstados();
                return Ok(estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetEstados(int id)
        {
            try
            {
                var estado = _estadoApplication.GetEstado(id);
                return Ok(estado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
