
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
    public class TipoLixoController : ControllerBase
    {
        readonly ITipoLixoApplication _tipoLixoApplication;

        public TipoLixoController(ITipoLixoApplication tipoLixoApplication)
        {
            _tipoLixoApplication = tipoLixoApplication;
        }




        [HttpPost]
        public IActionResult InsertLixo(string tiposLixo)
        {
            try
            {
                _tipoLixoApplication.InsertTipoLixo(tiposLixo);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
