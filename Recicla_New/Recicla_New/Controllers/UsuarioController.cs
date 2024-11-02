
using ApplicationService.Application;
using ApplicationService.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        readonly IUsuarioApplication _usuarioApplication;

        public UsuarioController(IUsuarioApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<Usuario>> Get()
        {
            return Ok(_usuarioApplication.GetUsuario());
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(int id)
        {
            return Ok(_usuarioApplication.GetUsuario(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Usuario> CreateUsuario(Usuario usuario)
        {

            _usuarioApplication.InsertUsuario(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.NomeCompleto }, usuario);
        }

        [HttpPut]
        public ActionResult Put([FromBody] Usuario usuario)
        {
            try
            {
                _usuarioApplication.UpdateUsuario(usuario);
                return Ok("Usuario Atualizado com sucesso!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _usuarioApplication.DeleteUsuario(id);
                return Ok("Usuario Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

      

    }
}
