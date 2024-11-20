
using ApplicationService.Application;
using ApplicationService.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserApplication _usuarioApplication;

        public UserController(IUserApplication usuarioApplication)
        {
            _usuarioApplication = usuarioApplication;
        }

        // GET: api/<AlunosController>
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            return Ok(_usuarioApplication.GetUsuario());
        }

        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            return Ok(_usuarioApplication.GetUsuario(id));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<User> CreateUsuario(User usuario)
        {

            _usuarioApplication.InsertUsuario(usuario);
            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut]
        public ActionResult Put([FromBody] User usuario)
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

/*        [HttpGet("{login}")]
        public IActionResult LoginUsuario(string username ,string passwordt)
        {
            var user = _usuarioApplication.LoginUsuario(username, passwordt);
            if (user == null)
            {
                return Unauthorized("Usu�rio ou senha incorretos");
            }

            // Retorna uma resposta com o usu�rio ou um token de autentica��o
            return Ok(user);
        }*/

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
