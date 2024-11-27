
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
    public class CaminhaoController : ControllerBase
    {
        readonly ICaminhaoApplication _caminhaoApplication;

        public CaminhaoController(ICaminhaoApplication caminhaoApplication)
        {
            _caminhaoApplication = caminhaoApplication;
        }

        [HttpGet]
        public IActionResult GetCaminhoes()
        {
            try
            {
                var caminhao = _caminhaoApplication.GetCaminhoes();
                return Ok(caminhao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetCaminhao(int id)
        {
            try
            {
                var caminhao = _caminhaoApplication.GetCaminhao(id);
                return Ok(caminhao);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertCaminhao(Caminhao caminhao)
        {
            try
            {
                _caminhaoApplication.InsertCaminhao(caminhao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("prototype")]
        public IActionResult InsertCaminhaoCloneSp(string placaUm, string placaDois, string modeloUm = "", string modeloDois = "")
        {
            try
            {
                var mensagens = _caminhaoApplication.InsertCaminhaoCloneSp(placaUm, placaDois, modeloUm, modeloDois);
                return Ok(new { Sucesso = true, Mensagens = mensagens });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateCaminhao(Caminhao caminhao)
        {
            try
            {
                _caminhaoApplication.UpdateCaminhao(caminhao);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCaminhao(int id)
        {
            try
            {
                _caminhaoApplication.DeleteCaminhao(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
